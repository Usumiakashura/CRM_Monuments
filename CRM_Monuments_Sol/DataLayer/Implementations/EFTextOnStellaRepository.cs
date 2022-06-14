using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Implementations
{
    public class EFTextOnStellaRepository : ITextOnStellaRepository
    {
        private EFDBContext _context;

        public EFTextOnStellaRepository(EFDBContext context)
        {
            _context = context;
        }

        public TextOnStella GetTextOnStellaById(int textOnStellaId)
        {
            return _context.TextOnStellas
                .Include(x => x.TypeText)
                .Include(x => x.Deceased)
                    .ThenInclude(x => x.Stella)
                    .ThenInclude(x => x.Contract)
                    .ThenInclude(x => x.Customers)
                .First(x => x.Id == textOnStellaId);
        }

        public void SaveTextOnStella(TextOnStella textOnStella)
        {
            if (textOnStella.Id == 0)
            {
                _context.TextOnStellas.Add(textOnStella);
            }
            else
            {
                _context.Entry(textOnStella).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }
        
        public void DeleteTextOnStella(TextOnStella textOnStella)
        {
            _context.TextOnStellas.Remove(textOnStella);
            _context.SaveChanges();
        }

        public void DeleteTextOnStellaByIdDeceased(int deceasedId)
        {
            TextOnStella textOnStella = 
                _context.TextOnStellas
                .Include(x => x.Deceased)
                .First(x => x.Deceased.Id == deceasedId);
            _context.TextOnStellas.Remove(textOnStella);
        }

        public void CompleateOnTextName(int idText, DateTime dateCompleate)    //отметить выполнение текста 
        {
            GetTextOnStellaById(idText).DateCompleatTextOnStella = dateCompleate;
            _context.SaveChanges();
        }

    }
}
