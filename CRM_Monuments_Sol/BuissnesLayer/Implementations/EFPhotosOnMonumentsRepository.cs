﻿using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entities;
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

        public EFPhotosOnMonumentsRepository(EFDBContext context)
        {
            _context = context;
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
        //public IEnumerable<Portrait> GetAllPortraits()     //получить все портреты
        //{
        //    var p = _context.PhotoOnMonuments.Where(x => x is Portrait);
        //    foreach (PhotoOnMonument ph in p)
        //    {
        //        yield return (Portrait)ph;
        //    }
        //}
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
