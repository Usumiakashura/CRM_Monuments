using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Implementations
{
    public class EFAccessorriesRepository : IAccessorriesRepository
    {
        private EFDBContext _context;

        public EFAccessorriesRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Accessorie> GetAllAccessoriesByIdContract(int contractId)     //получить весь список, относящийся к определенному договору
        {
            //List<Accessorie> accessories = new List<Accessorie>();
            //foreach (Accessorie a in _context.Accessories.Where(x => x.Contract.Id == contractId))
            //{
            //    if (a is StoneAccessorie)
            //    {
            //        ((StoneAccessorie)a).Material = _context.StoneMaterials.Find(((StoneAccessorie)a).StoneId);
            //    }
            //    accessories.Add(a);
            //}
            ////var accessories = _context.Accessories
            ////    .Include(a => a.Contract)
            ////    .Include(a => ((StoneAccessorie)a).Material)
            ////    .Where(a => a is StoneAccessorie && a.Contract.Id == contractId);
            //return accessories;

            throw new NotImplementedException();
            
        }

        public Accessorie GetAccessorieById(int accessorieId)    //получить один по айди
        {
            throw new NotImplementedException();
        }
        
        public void SaveAccessorie(Accessorie accessorie)        //сохранить в БД
        {
            throw new NotImplementedException();
        }
        
        public void DeleteAccessorie(Accessorie accessorie)      //удалить из бд
        {
            throw new NotImplementedException();
        }
        
        public void DeleteAllAccessoriesByIdContract(int contractId)      //удалить из бд все комплектующие по договору
        {
            throw new NotImplementedException();
        }

    }
}
