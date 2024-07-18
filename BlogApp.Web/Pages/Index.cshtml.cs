using BlogApp.Web.Data_Access;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<WebPost> WebPosts { get; set; }

        [BindProperty]
        public WebPost WebPost { get; set; }

        public ApplicationUser CurrentUser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            WebPost.ApplicationUserId = user.Id;

            _context.WebPosts.Add(WebPost);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task OnGetAsync()
        {
            WebPosts = await _context.WebPosts
            .Include(wp => wp.ApplicationUser)
            .OrderByDescending(wp => wp.DateTimeOfPost)
            .ToListAsync();

            CurrentUser = await _userManager.GetUserAsync(User);
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
