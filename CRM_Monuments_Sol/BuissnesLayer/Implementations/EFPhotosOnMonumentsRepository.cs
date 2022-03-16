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
        public EFPhotosOnMonumentsRepository(EFDBContext context)
        {
            _context = context;
        }

        public IEnumerable<PhotoOnMonument> GetAllPhotoOnMonumentsByIdDeceased(int deceasedId)     //получить весь список, относящийся к определенному договору
        {
            //var photos = _context.PhotoOnMonuments.Include(d => d.Deceased)
            //    .ThenInclude(c => c.Contract)
            //    .ThenInclude(c => c.Customers)
            //    .Where(x => x.Deceased.Id == deceasedId);
            List<PhotoOnMonument> photoOnMonuments = new List<PhotoOnMonument>();
            foreach (PhotoOnMonument p in _context.PhotoOnMonuments)
            {
                if (p is Portrait)
                    photoOnMonuments.Add(GetPortraitById(p.Id));
                else if (p is Medallion)
                    photoOnMonuments.Add(GetMedallionById(p.Id));
            }
            return photoOnMonuments;
        }
        public IEnumerable<PhotoOnMonument> GetAllPortraits()     //получить весь список портретов
        {
            var portraits = _context.PhotoOnMonuments
                .Include(d => d.Deceased)
                .ThenInclude(c => c.Contract)
                .ThenInclude(c => c.Customers)
                .Where(x => x is Portrait);
            foreach (Portrait portrait in portraits)
            {
                foreach (TypePortrait tp in _context.TypePortraits.Include(tp => tp.Portraits))
                {
                    if (//tp.Portraits.Count() > 0 && 
                        tp.Portraits.Where(x => x.Id == portrait.Id).Count() > 0)//.First() != null)
                        portrait.TypePortrait = tp;
                }
            }
            return portraits;
        }
        public IEnumerable<PhotoOnMonument> GetAllMedallions()     //получить весь список медальонов
        {
            var medallions = _context.PhotoOnMonuments
                .Include(d => d.Deceased)
                .ThenInclude(c => c.Contract)
                .ThenInclude(c => c.Customers)
                .Where(x => x is Medallion);
            foreach (Medallion medallion in medallions)
            {
                foreach (MedallionMaterial mm in _context.MedallionMaterials.Include(mm => mm.Medallions))
                {
                    if (//mm.Medallions.Count() > 0 &&
                        mm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//?.First() != null)
                        medallion.MedallionMaterialObj = mm;
                }
                foreach (ShapeMedallion sm in _context.ShapeMedallions.Include(sm => sm.Medallions))
                {
                    if (//sm.Medallions.Count() > 0 &&
                        sm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//.First() != null)
                        medallion.ShapeMedallionObj = sm;
                }
                foreach (ColorMedallion cm in _context.ColorMedallions.Include(cm => cm.Medallions))
                {
                    if (//cm.Medallions.Count() > 0 &&
                        cm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//.First() != null)
                        medallion.ColorMedallionObj = cm;
                }
            }

            return medallions;
        }
        public Portrait GetPortraitById(int id)
        {
            Portrait portrait = (Portrait)_context.PhotoOnMonuments
                .Include(d => d.Deceased)
                .ThenInclude(c => c.Contract)
                .ThenInclude(c => c.Customers)
                .Where(x => x.Id == id).First();
            foreach (TypePortrait tp in _context.TypePortraits.Include(tp => tp.Portraits))
            {
                if (//tp.Portraits.Count() > 0 &&
                    tp.Portraits.Where(x => x.Id == portrait.Id).Count() > 0)//.First() != null)
                    portrait.TypePortrait = tp;
            }
            return portrait;
        }
        public Medallion GetMedallionById(int id)
        {
            Medallion medallion = (Medallion)_context.PhotoOnMonuments
                .Include(d => d.Deceased)
                .ThenInclude(c => c.Contract)
                .ThenInclude(c => c.Customers)
                .Where(x => x.Id == id).First();
            foreach (MedallionMaterial mm in _context.MedallionMaterials.Include(mm => mm.Medallions))
            {
                if (//mm.Medallions.Count() > 0 &&
                    mm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//.First() != null)
                    medallion.MedallionMaterialObj = mm;
            }
            foreach (ShapeMedallion sm in _context.ShapeMedallions.Include(sm => sm.Medallions))
            {
                if (//sm.Medallions.Count() > 0 &&
                    sm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//.First() != null)
                    medallion.ShapeMedallionObj = sm;
            }
            foreach (ColorMedallion cm in _context.ColorMedallions.Include(cm => cm.Medallions))
            {
                if (//cm.Medallions.Count() > 0 &&
                    cm.Medallions.Where(x => x.Id == medallion.Id).Count() > 0)//.First() != null)
                    medallion.ColorMedallionObj = cm;
            }
            return medallion;
        }

        public PhotoOnMonument GetPhotoOnMonumentById(int photoOnMonumentId)    //получить один по айди
        {
            PhotoOnMonument photoOnMonument = _context.PhotoOnMonuments
                .Where(x => x.Id == photoOnMonumentId).First();
            return photoOnMonument;
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
            {
                _context.Entry(photoOnMonument).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
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
        }
    }
}
