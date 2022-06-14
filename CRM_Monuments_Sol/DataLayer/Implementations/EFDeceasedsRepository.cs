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
    public class EFDeceasedsRepository : IDeceasedsRepository
    {
        private EFDBContext _context;
        private IPhotosOnMonumentsRepository _photosOnMonumentsRepository;
        private IEpitaphRepository _epitaphRepository;
        private ITextOnStellaRepository _textOnStellaRepository;

        public EFDeceasedsRepository(EFDBContext context)
        {
            _context = context;
            _photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(_context);
            _epitaphRepository = new EFEpitaphRepository(_context);
            _textOnStellaRepository = new EFTextOnStellaRepository(_context);
        }

        public IEnumerable<Deceased> GetAllDeceasedsByIdStella(int stellaId)     //получить весь список, относящийся к определенному договору
        {
            var deceaseds = _context.Deceaseds
                .Include(e => e.Epitaphs).ThenInclude(x => x.TypeText)
                .Include(e => e.TextOnStella).ThenInclude(x => x.TypeText)
                .Include(d => d.Stella).ThenInclude(x => x.Contract).ThenInclude(x => x.Customers)
                .Include(p => p.PhotosOnMonument)
                .Where(x => x.Stella.Id == stellaId);
            return deceaseds;
        }

        public Deceased GetDeceasedById(int deceasedId)    //получить один по айди
        {
            Deceased deceased = _context.Deceaseds
                .Include(e => e.Epitaphs).ThenInclude(x => x.TypeText)
                .Include(e => e.TextOnStella).ThenInclude(x => x.TypeText)
                .Include(d => d.Stella).ThenInclude(x => x.Contract).ThenInclude(x => x.Customers)
                .Include(p => p.PhotosOnMonument)
                .FirstOrDefault(x => x.Id == deceasedId);
            return deceased;
        }

        public void SaveDeceased(Deceased deceased)        //сохранить в БД
        {
            if (deceased.Id == 0)
            {
                _context.Deceaseds.Add(deceased);
            }
            else
            {
                foreach (PhotoOnMonument p in deceased.PhotosOnMonument)
                {
                    _photosOnMonumentsRepository.SavePhotoOnMonument(p);
                }
                foreach (Epitaph e in deceased.Epitaphs)
                {
                    _epitaphRepository.SaveEpitaph(e);
                }
                _textOnStellaRepository.SaveTextOnStella(deceased.TextOnStella);
                _context.Entry(deceased).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteDeceased(Deceased deceased)      //удалить из бд
        {
            _photosOnMonumentsRepository.DeleteAllPhotoOnMonumentByIdDeceased(deceased.Id);
            _epitaphRepository.DeleteAllEpitaphsByIdDeceased(deceased.Id);
            _context.TextOnStellas.Remove(deceased.TextOnStella);
            _context.Deceaseds.Remove(deceased);
            _context.SaveChanges();
        }

        public void DeleteAllDeceasedsByIdStella(int stellaId)      //удалить из бд всех усопших со стеллы
        {
            foreach (Deceased d in GetAllDeceasedsByIdStella(stellaId))
            {
                _photosOnMonumentsRepository.DeleteAllPhotoOnMonumentByIdDeceased(d.Id);
                _epitaphRepository.DeleteAllEpitaphsByIdDeceased(d.Id);
                _context.TextOnStellas.Remove(d.TextOnStella);
                _context.Deceaseds.Remove(d);
            }
            //_context.SaveChanges();
        }

    }
}
