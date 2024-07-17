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

        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<WebPost> WebPosts { get; set; }

        [BindProperty]
        public WebPost WebPost { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            WebPost.ApplicationUserId = user.Id;

            //WebPosts = await _context.WebPosts
            //  .Include(p => p.ApplicationUser)
            //  .ToListAsync();
    
            _context.WebPosts.Add(WebPost);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }

        public async Task OnGetAsync()
        {
            //var user = new ApplicationUser()
            //{
            //    WebPosts.
            //};

            WebPosts = await _context.WebPosts
            .Include(p => p.ApplicationUser)
            .ToListAsync();
        }

        //user.WebPosts
        //User = _context.Users.Include
        //(wp => wp.WebPosts)
        //.ToList();

    }

    
}
