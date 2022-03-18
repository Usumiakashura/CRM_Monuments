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
    public class EFTypesTextsRepository : ITypesTextsRepository
    {
        private EFDBContext _context;
        public EFTypesTextsRepository(EFDBContext context)
        {
            _context = context;
        }
        
        public IEnumerable<TypeText> GetAllTypesText()
        {
            List<TypeText> pointsForSelect = new List<TypeText>();
            foreach (TypeText tt in _context.TypeTexts.Include(d => d.Deceaseds).Include(e => e.Epitaphs))
                pointsForSelect.Add(tt);
            return pointsForSelect;
        }

        public void SaveTypeText(TypeText typeText)
        {
            if (typeText.Id == 0)
            {
                _context.TypeTexts.Add(typeText);
            }
            else
            {
                _context.Entry(typeText).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteTypeText(TypeText typeText)
        {
            _context.TypeTexts.Remove(typeText);
            _context.SaveChanges();
        }
    }
}
