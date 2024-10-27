using BlogApp.Web.Data;
using BlogApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace BlogApp.Web.Pages
{
    public class FriendsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FriendsModel(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public ApplicationUser CurrentUser { get; set; }
        public ApplicationUser FriendUser { get; set; }

        public List<Friendship> Friendships { get; set; }

        public async Task OnGetAsync()
        {
            CurrentUser = await _userManager.GetUserAsync(User);

            Friendships = await _context.Friendships
                .Include(f => f.Friend)
                .Include(f => f.User)
                .Where(f => f.FriendId == CurrentUser.Id && f.FriendStatus == Enums.FriendshipStatus.Requested)
                .ToListAsync();

        }
    }
}
