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

        public void DeleteEpitaph(Epitaph epitaph)
        {
            _context.Epitaphs.Remove(epitaph);
            //_context.SaveChanges();
        }

        public Epitaph GetEpitaphByIdDeceased(int idDeceased)
        {
            return _context.Epitaphs.Include(d => d.Deceased).Where(e => e.Deceased.Id == idDeceased).First();
        }

        public void SaveEpitaph(Epitaph epitaph)
        {
            if (epitaph.Id == 0)
            {
                epitaph.Id = 0;
                _context.Epitaphs.Add(epitaph);
            }
            else
            {
                _context.Entry(epitaph).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void CompleateOnTextEpitaph(int idDeceaced, DateTime dateCompleate) //отметить выполнение текста эпитафии
        {
            GetEpitaphByIdDeceased(idDeceaced).DateCompleatTextEpitaph = dateCompleate;
            _context.SaveChanges();
        }
    }
}
