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
    public class EFDeceasedsRepository : IDeceasedsRepository
    {
        private EFDBContext _context;
        private IPhotosOnMonumentsRepository _photosOnMonumentsRepository;
        private IEpitaphRepository _epitaphRepository;

        public EFDeceasedsRepository(EFDBContext context)
        {
            _context = context;
            _photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(_context);
            _epitaphRepository = new EFEpitaphRepository(_context);
        }

        public IEnumerable<Deceased> GetAllDeceasedsByIdContract(int contractId)     //получить весь список, относящийся к определенному договору
        {
            var deceaseds = _context.Deceaseds
                .Include(e => e.Epitaph).ThenInclude(x => x.TypeTextObj)
                .Include(d => d.Contract).ThenInclude(x => x.Customers)
                .Include(p => p.PhotosOnMonument)
                .Where(d => d.Contract.Id == contractId);
            //foreach (Deceased d in deceaseds)
            //{
            //    _photosOnMonumentsRepository.GetAllPhotoOnMonumentsByIdDeceased(d.Id);
            //}
            return deceaseds;
        }

        public Deceased GetDeceasedById(int deceasedId)    //получить один по айди
        {
            Deceased deceased = _context.Deceaseds
                .Include(x => x.Contract).ThenInclude(x => x.Customers)
                .Include(x => x.TypeTextObj)
                .Include(x => x.Epitaph).ThenInclude(x => x.TypeTextObj)
                .Where(x => x.Id == deceasedId).First();
            //deceased.Epitaph = _epitaphRepository.GetEpitaphByIdDeceased(deceasedId);
            return deceased;
        }

        public void CompleateOnTextName(int idDeceaced, DateTime dateCompleate)    //отметить выполнение текста ФИО
        {
            GetDeceasedById(idDeceaced).DateCompleatTextName = dateCompleate;
            _context.SaveChanges();
        }
        //public void CompleateOnTextEpitaph(int idDeceaced, DateTime dateCompleate) //отметить выполнение текста эпитафии
        //{
        //    GetDeceasedById(idDeceaced).Epitaph.DateCompleatTextEpitaph = dateCompleate;
        //    _context.SaveChanges();
        //}

        public void SaveDeceased(Deceased deceased)        //сохранить в БД
        {
            if (deceased.Id == 0)
            {
                deceased.Id = 0;
                _context.Deceaseds.Add(deceased);
            }
            else
            {
                foreach (PhotoOnMonument p in deceased.PhotosOnMonument)
                {
                    _photosOnMonumentsRepository.SavePhotoOnMonument(p);
                }
                _epitaphRepository.SaveEpitaph(deceased.Epitaph);
                _context.Entry(deceased).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteDeceased(Deceased deceased)      //удалить из бд
        {
            _photosOnMonumentsRepository.DeleteAllPhotoOnMonumentByIdDeceased(deceased.Id);
            _context.Epitaphs.Remove(deceased.Epitaph);
            _context.Deceaseds.Remove(deceased);
            _context.SaveChanges();
        }

        public void DeleteAllDeceasedsByIdContract(int contractId)      //удалить из бд всех усопших по договору
        {
            foreach (Deceased d in GetAllDeceasedsByIdContract(contractId))
            {
                _photosOnMonumentsRepository.DeleteAllPhotoOnMonumentByIdDeceased(d.Id);
                _epitaphRepository.DeleteEpitaph(d.Epitaph);
                _context.Deceaseds.Remove(d);
            }
            //_context.SaveChanges();
        }

    }
}
