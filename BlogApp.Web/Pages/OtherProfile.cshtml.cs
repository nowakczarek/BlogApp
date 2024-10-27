using BlogApp.Web.Data;
using BlogApp.Web.Enums;
using BlogApp.Web.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Pages
{
    public class OtherProfileModel : PageModel
    {
		private readonly ApplicationDbContext _context;
		private readonly UserManager<ApplicationUser> _userManager;

		public OtherProfileModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
			_userManager = userManager;
		}

        public ApplicationUser CurrentUser { get; set; }

		public ApplicationUser ProfileUser { get; set; }

        [BindProperty]
        public Comment Comment { get; set; }

        [BindProperty]
        public Friendship Friendship { get; set; }

        public FriendshipStatus? CurrentFriendshipStatus { get; set; }

        public List<WebPost> WebPosts { get; set; }

        public string ProfileUserId { get; set; }

        public async Task OnGetAsync(string id)
        {
            ProfileUserId = id;

            CurrentUser = await _userManager.GetUserAsync(User);
            ProfileUser = await _context.Users.FindAsync(ProfileUserId);

            WebPosts = await _context.WebPosts
            .Include(wp => wp.ApplicationUser)
            .Where(wp => wp.ApplicationUserId == ProfileUserId)
            .Include(wp => wp.Comments)
                .ThenInclude(c => c.ApplicationUser)
            .OrderByDescending(wp => wp.DateTimeOfPost)
            .ToListAsync();


            var friendship = await _context.Friendships.FirstOrDefaultAsync
                (f => (CurrentUser.Id == f.UserId && id == f.FriendId) || (id == f.UserId && CurrentUser.Id == f.FriendId));

            if (friendship != null)
            {
                CurrentFriendshipStatus = friendship?.FriendStatus;

            }

        }

        public async Task<IActionResult> OnPostAddCommentAsync(int webPostId)
		{
            CurrentUser = await _userManager.GetUserAsync(User);
			var webPost = await _context.WebPosts.FindAsync(webPostId);

            ProfileUser = await _context.Users.FindAsync(webPost.ApplicationUserId);

            Comment.ApplicationUserId = CurrentUser.Id;
			Comment.WebPostId = webPost.Id;

			_context.Comments.Add(Comment);
			await _context.SaveChangesAsync();

            WebPosts = await _context.WebPosts
            .Include(wp => wp.ApplicationUser)
            .Where(wp => wp.ApplicationUserId == webPost.ApplicationUserId)
            .Include(wp => wp.Comments)
                .ThenInclude(c => c.ApplicationUser)
            .OrderByDescending(wp => wp.DateTimeOfPost)
            .ToListAsync();

            return Page();
        }

        public async Task<IActionResult> OnPostAddFriend(string ProfileUserId)
        {
            CurrentUser = await _userManager.GetUserAsync(User);
            ProfileUser = await _context.Users.FindAsync(ProfileUserId);

            Friendship = new Friendship
            {
                UserId = CurrentUser.Id,
                FriendId = ProfileUserId,
                FriendStatus = FriendshipStatus.Requested,
                CreatedDate = DateTime.Now
            };

            _context.Friendships.Add(Friendship);

            await _context.SaveChangesAsync();

            WebPosts = await _context.WebPosts
            .Include(wp => wp.ApplicationUser)
            .Where(wp => wp.ApplicationUserId == ProfileUserId)
            .Include(wp => wp.Comments)
                .ThenInclude(c => c.ApplicationUser)
            .OrderByDescending(wp => wp.DateTimeOfPost)
            .ToListAsync();

            return RedirectToPage(new {id = ProfileUserId});
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var post = await _context.WebPosts.FindAsync(id);

            _context.WebPosts.Remove(post);
            _context.SaveChanges();

            return Page();
        }
    }
}
