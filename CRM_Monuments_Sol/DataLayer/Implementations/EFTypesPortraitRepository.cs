using DataLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Context;

namespace DataLayer.Implementations
{
    public class EFTypesPortraitRepository : ITypesPortraitRepository
    {
        private EFDBContext _context;
        private EFPhotosOnMonumentsRepository _photosOnMonumentsRepository;

        public EFTypesPortraitRepository(EFDBContext context)
        {
            _context = context;
            _photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(_context);
        }
        
        public IEnumerable<TypePortrait> GetAllTypesPortraits()
        {
            return _context.TypePortraits.Include(tp => tp.Portraits);
        }

        public void SaveTypePortrait(TypePortrait typePortrait)
        {
            if (typePortrait.Id == 0)
            {
                _context.TypePortraits.Add(typePortrait);
            }
            else
            {
                _context.Entry(typePortrait).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }
        public void DeleteTypePortrait(TypePortrait typePortrait)
        {
            _context.TypePortraits.Remove(typePortrait);
            _context.SaveChanges();
        }
    }
}
