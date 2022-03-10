using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.ApplicationEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFApplicationUsersRepository : IApplicationUsersRepository
    {
        private ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        RoleManager<IdentityRole> _roleManager;

        public EFApplicationUsersRepository(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllArtists()
        {
            var role = await _roleManager.FindByNameAsync("artist");
            var users = new List<ApplicationUser>();
            foreach (ApplicationUser user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    users.Add(user);
                    //yield return user;
                }
            }

            //string roleName = "artist";
            //var role = await _roleManager.Roles.SingleAsync(r => r.Name == roleName);

            //var users = await _userManager.IsInRoleAsync();

            //var users = from u in _context.Users
            //            where u.Roles.Any(r => r.Role.Name == roleName)
            //            select u;

            return users;
        }

        public IEnumerable<ApplicationUser> GetAllEngravers()
        {
            throw new NotImplementedException();
        }
    }
}
