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
        public Comment Comment { get; set; }

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
    }
}
