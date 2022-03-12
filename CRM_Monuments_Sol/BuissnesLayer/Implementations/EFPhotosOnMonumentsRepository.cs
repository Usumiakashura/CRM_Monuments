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
    public class EFPhotosOnMonumentsRepository : IPhotosOnMonumentsRepository
    {
        private EFDBContext _context;
        //private ITypesPortraitRepository _typesPortraitRepository;
        public EFPhotosOnMonumentsRepository(EFDBContext context)
        {
            _context = context;
            //_typesPortraitRepository = new EFTypesPortraitRepository(_context);
        }

        public IEnumerable<PhotoOnMonument> GetAllPhotoOnMonumentsByIdDeceased(int deceasedId)     //получить весь список, относящийся к определенному договору
        {
            return _context.PhotoOnMonuments.Where(x => x.Deceased.Id == deceasedId);
        }
        public PhotoOnMonument GetPhotoOnMonumentById(int photoOnMonumentId)    //получить один по айди
        {
            PhotoOnMonument photoOnMonument = _context.PhotoOnMonuments.Find(photoOnMonumentId);
            return photoOnMonument;
        }
        public IEnumerable<Portrait> GetAllPortraits()     //получить все портреты
        {
            List<Portrait> portraits = new List<Portrait>();
            var p = _context.PhotoOnMonuments.Where(x => x is Portrait);
            //foreach (Portrait ph in _context.PhotoOnMonuments.Where(x => x is Portrait))
            //{
            //    ph.TypePortrait = _typesPortraitRepository.GetTypePortraitByIdPortrait(ph.Id);
            //}
            return portraits;
        }
        //public IEnumerable<Medallion> GetAllMedallions()     //получить все медальоны
        //{
        //    var m = _context.PhotoOnMonuments.Where(x => x is Medallion);
        //    List<Medallion> medallions = new List<Medallion>();
        //    foreach (PhotoOnMonument ph in m)
        //    {
        //        medallions.Add((Medallion)ph);
        //    }
        //    return medallions;
        //}
        public void CompleateOn(int idPhotoOnMonument, DateTime dateCompleate)  //отметка о выполнении
        {
            GetPhotoOnMonumentById(idPhotoOnMonument).DateCompleat = dateCompleate;
            _context.SaveChanges();
        }
        public void SavePhotoOnMonument(PhotoOnMonument photoOnMonument)        //сохранить в БД
        {
            if (photoOnMonument.Id == 0)
            {
                photoOnMonument.Id = 0;
                _context.PhotoOnMonuments.Add(photoOnMonument);
            }
            else
            {
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).DateBegin = photoOnMonument.DateBegin;
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).DateCompleat = photoOnMonument.DateCompleat;
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).Deceased = photoOnMonument.Deceased;
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).Note = photoOnMonument.Note;
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).PhotoName = photoOnMonument.PhotoName;
                _context.PhotoOnMonuments.Find(photoOnMonument.Id).PhotoPath = photoOnMonument.PhotoPath;
                if (photoOnMonument is Portrait)
                {
                    Portrait portrait = (Portrait)_context.PhotoOnMonuments.Find(photoOnMonument.Id);
                    portrait.TypePortrait = ((Portrait)photoOnMonument).TypePortrait;
                    portrait.TypePortraitId = portrait.TypePortrait.Id;
                    portrait.TypePortraitName = portrait.TypePortrait.Name;
                    portrait.Artist = ((Portrait)photoOnMonument).Artist;
                }
                
            }
                //_context.Entry(photoOnMonument).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void DeletePhotoOnMonument(PhotoOnMonument photoOnMonument)      //удалить из бд
        {
            _context.PhotoOnMonuments.Remove(photoOnMonument);
            _context.SaveChanges();
        }
        public void DeleteAllPhotoOnMonumentByIdDeceased(int deceasedId)      //удалить из бд все фото по усопшему
        {
            foreach (PhotoOnMonument p in GetAllPhotoOnMonumentsByIdDeceased(deceasedId))
            {
                _context.PhotoOnMonuments.Remove(p);
            }
            //_context.SaveChanges();
        }
    }
}
