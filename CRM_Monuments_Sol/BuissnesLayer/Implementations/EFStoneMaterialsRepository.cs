using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFStoneMaterialsRepository : IStoneMaterialsRepository
    {
        private EFDBContext _context;

        public EFStoneMaterialsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<StoneMaterial> GetAllStoneMaterials()     //получить весь список
        {
            return _context.StoneMaterials;
        }

        public IEnumerable<PhotoOnMonument> GetAllPhotoOnMonumentsByIdDeceased(int deceasedId)     //получить весь список, относящийся к определенному договору
        {
            //return _context.StoneMaterials.Where(x => x.StoneAccessories.Id == deceasedId);
            throw new NotImplementedException();
        }

        public StoneMaterial GetStoneMaterialById(int accessorieId)    //получить один по айди
        {
            return _context.StoneMaterials.Find(accessorieId);
        }
        
        public void SaveStoneMaterial(StoneMaterial stoneMaterial)        //сохранить в БД
        {
            throw new NotImplementedException();
        }
        
        public void DeleteStoneMaterial(StoneMaterial stoneMaterial)      //удалить из бд
        {
            throw new NotImplementedException();
        }
    }
}
