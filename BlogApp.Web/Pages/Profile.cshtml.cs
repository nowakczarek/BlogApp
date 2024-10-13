using BlogApp.Web.Data_Access;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Pages
{
    public class ProfileModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ApplicationUser CurrentUser { get; set; }
        public List<WebPost> WebPosts { get; set; }
        public List<Comment> Comments { get; set; }

        [BindProperty]
        public WebPost WebPost { get; set; }

        [BindProperty]
        public Comment Comment { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task OnGetAsync()
        {
            CurrentUser = await _userManager.GetUserAsync(User);

            WebPosts = await _context.WebPosts
            .Include(wp => wp.ApplicationUser)
            .Where(wp => wp.ApplicationUser == CurrentUser)
            .Include(wp => wp.Comments)
                .ThenInclude(c => c.ApplicationUser)
            .OrderByDescending(wp => wp.DateTimeOfPost)
            .ToListAsync();
        }

        public async Task<IActionResult> OnPostAddWebPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            WebPost.ApplicationUserId = user.Id;


            var fileName = Path.GetFileNameWithoutExtension(Image.FileName);
            var extension = Path.GetExtension(Image.FileName);
            var newFileName = $"{fileName}_{DateTime.Now.Ticks}{extension}";
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", newFileName);

            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads"));
            }

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await Image.CopyToAsync(stream);
            }


            WebPost.ImagePath = $"/uploads/{newFileName}";


            _context.WebPosts.Add(WebPost);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddCommentAsync(int webPostId)
        {
            var user = await _userManager.GetUserAsync(User);
            var webPost = await _context.WebPosts.FindAsync(webPostId);

            Comment.ApplicationUserId = user.Id;
            Comment.WebPostId = webPost.Id;

            _context.Comments.Add(Comment);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var post = await _context.WebPosts.FindAsync(id);

            _context.WebPosts.Remove(post);
            _context.SaveChanges();

            return RedirectToPage();
        }

    }
}
