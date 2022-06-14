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
    public class EFStellaRepository : IStellaRepository
    {
        private EFDBContext _context;
        private IDeceasedsRepository _deceasedsRepository;

        public EFStellaRepository(EFDBContext context)
        {
            _context = context;
            _deceasedsRepository = new EFDeceasedsRepository(_context);
        }

        public IEnumerable<Stella> GetAllStellasByIdContract(int contractId)
        {
            var stellas = _context.Stellas
                .Include(d => d.Deceaseds)
                .ThenInclude(e => e.TextOnStella).ThenInclude(x => x.TypeText)
                .Include(d => d.Deceaseds).ThenInclude(x => x.Epitaphs)
                .Include(d => d.Deceaseds).ThenInclude(x => x.PhotosOnMonument)
                .Include(d => d.Contract).ThenInclude(x => x.Customers)
                .Where(d => d.Contract.Id == contractId);
            return stellas;
        }

        public Stella GetStellaById(int stellaId)
        {
            var stella = _context.Stellas
                .Include(d => d.Deceaseds)
                .ThenInclude(e => e.TextOnStella).ThenInclude(x => x.TypeText)
                .Include(d => d.Deceaseds).ThenInclude(x => x.Epitaphs)
                .Include(d => d.Deceaseds).ThenInclude(x => x.PhotosOnMonument)
                .Include(d => d.Contract).ThenInclude(x => x.Customers)
                .FirstOrDefault(x => x.Id == stellaId);
            return stella;
        }

        public void SaveStella(Stella stella)
        {
            if (stella.Id == 0)
            {
                _context.Stellas.Add(stella);
            }
            else
            {
                foreach (Deceased d in stella.Deceaseds)
                {
                    _deceasedsRepository.SaveDeceased(d);
                }
                _context.Entry(stella).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteStella(Stella stella)
        {
            _deceasedsRepository.DeleteAllDeceasedsByIdStella(stella.Id);
            _context.Stellas.Remove(stella);
            _context.SaveChanges();
        }

        public void DeleteAllStellasByIdContract(int contractId)
        {
            foreach (Stella s in GetAllStellasByIdContract(contractId))
            {
                _deceasedsRepository.DeleteAllDeceasedsByIdStella(s.Id);
                _context.Stellas.Remove(s);
            }
            //throw new NotImplementedException();
        }
        
    }
}
