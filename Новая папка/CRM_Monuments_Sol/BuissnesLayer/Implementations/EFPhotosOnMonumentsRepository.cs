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
        private ITypesPortraitRepository _typesPortraitRepository;

        public EFPhotosOnMonumentsRepository(EFDBContext context)
        {
            _context = context;
            _typesPortraitRepository = new EFTypesPortraitRepository(_context);
        }

        public IEnumerable<PhotoOnMonument> GetAllPhotoOnMonumentsByIdDeceased(int deceasedId)     //получить весь список, относящийся к определенному договору
        {
            List<PhotoOnMonument> allPhotos = new List<PhotoOnMonument>();
            foreach (var p in _context.PhotoOnMonuments.Where(x => x.Deceased.Id == deceasedId))
            {
                allPhotos.Add(GetPhotoOnMonumentById(p.Id));
            }

            return allPhotos;//_context.PhotoOnMonuments.Where(x => x.Deceased.Id == deceasedId);
        }
        public PhotoOnMonument GetPhotoOnMonumentById(int photoOnMonumentId)    //получить один по айди
        {
            PhotoOnMonument photoOnMonument = _context.PhotoOnMonuments.Find(photoOnMonumentId);
            if (photoOnMonument is Portrait)
            {
                ((Portrait)photoOnMonument).TypePortraitObj = _typesPortraitRepository.GetTypePortraitByIdPortrait(photoOnMonumentId);
                //foreach (var tp in _context.TypePortraits.Include(t => t.Portraits))
                //{
                //    var type = tp.Portraits.Where(p => p.Id == photoOnMonument.Id);
                //    if (type.Count() > 0) ((Portrait)photoOnMonument).TypePortraitObj = tp;
                //}
            }
            //else if (photoOnMonument is Medallion)
            //{
            //    foreach (var tp in _context.MedallionMaterials.Include(t => t.Portraits))
            //    {
            //        var type = tp.Portraits.Where(p => p.Id == photoOnMonument.Id);
            //        if (type.Count() > 0) ((Portrait)photoOnMonument).TypePortraitObj = tp;
            //    }
            //    foreach (var tp in _context.ShapeMedallions.Include(t => t.Portraits))
            //    {
            //        var type = tp.Portraits.Where(p => p.Id == photoOnMonument.Id);
            //        if (type.Count() > 0) ((Portrait)photoOnMonument).TypePortraitObj = tp;
            //    }
            //    foreach (var tp in _context.ColorMedallions.Include(t => t.Portraits))
            //    {
            //        var type = tp.Portraits.Where(p => p.Id == photoOnMonument.Id);
            //        if (type.Count() > 0) ((Portrait)photoOnMonument).TypePortraitObj = tp;
            //    }
            //}



            return photoOnMonument;
        }
        public IEnumerable<Portrait> GetAllPortraits()     //получить все портреты
        {
            var p = _context.PhotoOnMonuments.Where(x => x is Portrait);
            List<Portrait> portraits = new List<Portrait>();
            foreach (PhotoOnMonument ph in p)
            {
                ((Portrait)ph).TypePortraitObj = _typesPortraitRepository.GetTypePortraitByIdPortrait(ph.Id);
                portraits.Add((Portrait)ph);
            }
            return portraits;
        }
        public IEnumerable<Medallion> GetAllMedallions()     //получить все медальоны
        {
            var m = _context.PhotoOnMonuments.Where(x => x is Medallion);
            List<Medallion> medallions = new List<Medallion>();
            foreach (PhotoOnMonument ph in m)
            {
                medallions.Add((Medallion)ph);
            }
            return medallions;
        }
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
                _context.Entry(photoOnMonument).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
