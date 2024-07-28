using BlogApp.Web.Data_Access;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogApp.Web.Pages
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WebPost WebPost { get; set; }

        public async Task OnGetAsync(int id)
        {
            WebPost = await _context.WebPosts.FindAsync(id);

        }

        public async Task<IActionResult> OnPostUpdateAsync(int id)
        {
            var post = await _context.WebPosts.FindAsync(id);

            var changesHistory = new WebPostChangesHistory();

            changesHistory.WebPostId = post.Id;
            changesHistory.Contents = post.Contents;
            changesHistory.DateTimeOfPost = post.DateTimeOfPost;

            _context.WebPostsChangesHistory.Add(changesHistory);

            post.Contents = WebPost.Contents;
            post.DateTimeOfPost = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
