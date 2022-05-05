using DataLayer.Interfaces;
using DataLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;
using DataLayer.Entities;

namespace DataLayer.Implementations
{
    public class EFApplicationUsersRepository : IApplicationUsersRepository
    {
        private EFDBContext _context;
        private UserManager<ApplicationUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly UserManager<ApplicationUser> _userManager;

        public EFApplicationUsersRepository(EFDBContext context,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllArtists()
        {
            return await GetAllByRole("artist");
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllEngravers()
        {
            return await GetAllByRole("engraver");
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            return await _userManager.Users.ToListAsync();
        }

        //--------------------------------------------------------------
        private async Task<IEnumerable<ApplicationUser>> GetAllByRole(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            var users = new List<ApplicationUser>();
            foreach (ApplicationUser user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    users.Add(user);
                }
            }
            return users;
        }

    }
}
