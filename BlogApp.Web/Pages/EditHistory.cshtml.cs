using BlogApp.Web.Data_Access;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Pages
{
    public class EditHistoryModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditHistoryModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<WebPostChangesHistory> ChangesHistory { get; set; }
        public async Task OnGetAsync(int id)
        {
            //var posts = await _context.WebPostsChangesHistory.FindAsync(id);

            ChangesHistory = await _context.WebPostsChangesHistory
                .Where(p => p.WebPostId == id)
                .OrderByDescending(c => c.DateTimeOfPost)
                .ToListAsync();
        }
    }
}