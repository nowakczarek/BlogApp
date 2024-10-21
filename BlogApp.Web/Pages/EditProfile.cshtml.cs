using BlogApp.Web.Data_Access;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Web.Pages
{
    public class EditProfileModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public EditProfileModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }
        public ApplicationUser CurrentUser { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }


        public async Task OnGetAsync()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            CurrentUser = await _userManager.GetUserAsync(User);

            return Page();
        }

    }
}
