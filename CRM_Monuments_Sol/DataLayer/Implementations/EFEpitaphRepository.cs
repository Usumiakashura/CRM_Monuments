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
    public class EFEpitaphRepository : IEpitaphRepository
    {
        private EFDBContext _context;

        public EFEpitaphRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Epitaph> GetAllEpitaphsByIdDeceased(int idDeceased)
        {
            return _context.Epitaphs
                .Include(d => d.TypeText)
                .Include(x => x.Deceased)
                    .ThenInclude(x => x.TextOnStella)
                .Include(x => x.Deceased)
                    .ThenInclude(x => x.Stella)
                    .ThenInclude(x => x.Contract)
                    .ThenInclude(x => x.Customers)
                .Where(e => e.Deceased.Id == idDeceased);
        }

        public Epitaph GetEpitaphById(int idEpitaph)
        {
            return _context.Epitaphs
                .Include(d => d.TypeText)
                .Include(x => x.Deceased)
                    .ThenInclude(x => x.TextOnStella)
                .Include(x => x.Deceased)
                    .ThenInclude(x => x.Stella)
                    .ThenInclude(x => x.Contract)
                    .ThenInclude(x => x.Customers)
                .First(e => e.Id == idEpitaph);
        }

        public void SaveEpitaph(Epitaph epitaph)
        {
            if (epitaph.Id == 0)
            {
                _context.Epitaphs.Add(epitaph);
            }
            else
            {
                _context.Entry(epitaph).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteEpitaph(Epitaph epitaph)
        {
            _context.Epitaphs.Remove(epitaph);
            _context.SaveChanges();
        }

        public void DeleteAllEpitaphsByIdDeceased(int deceasedId)
        {
            foreach (Epitaph e in GetAllEpitaphsByIdDeceased(deceasedId))
            {
                _context.Epitaphs.Remove(e);
            }
        }

        public void CompleateOnTextEpitaph(int idEpitaph, DateTime dateCompleate) //отметить выполнение текста эпитафии
        {
            GetEpitaphById(idEpitaph).DateCompleatTextEpitaph = dateCompleate;
            _context.SaveChanges();
        }
    }
}
