using DataLayer.ApplicationEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IApplicationUsersRepository
    {
        public Task<IEnumerable<ApplicationUser>> GetAllArtists();    //получить всех художников
        public Task<IEnumerable<ApplicationUser>> GetAllEngravers();    //получить всех граверов
        public Task<IEnumerable<ApplicationUser>> GetAllUsers();
    }
}
