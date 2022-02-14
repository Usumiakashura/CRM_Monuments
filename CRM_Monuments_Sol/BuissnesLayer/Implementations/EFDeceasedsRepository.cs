﻿using BuissnesLayer.Interfaces;
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

        public EFDeceasedsRepository(EFDBContext context)
        {
            _context = context;
            _photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(_context);
        }

        public IEnumerable<Deceased> GetAllDeceasedsByIdContract(int contractId)     //получить весь список, относящийся к определенному договору
        {
            //List<Deceased> deceaseds = new List<Deceased>();
            //foreach (Deceased d in _context.Deceaseds.Where(x => x.Contract.Id == contractId))
            //{
            //    FillDeceasedsPhotoOnMonument(d);   //достаем из бд все фото и их оформления
            //    deceaseds.Add(d);
            //}
            var deceaseds = _context.Deceaseds.Include(d => d.PhotosOnMonument)
                .Include(d => d.Contract).Where(d => d.Contract.Id == contractId);
            return deceaseds;
        }

        public Deceased GetDeceasedById(int deceasedId)    //получить один по айди
        {
            throw new NotImplementedException();
        }

        public void SaveDeceased(Deceased deceased)        //сохранить в БД
        {
            throw new NotImplementedException();
        }

        public void DeleteDeceased(Deceased deceased)      //удалить из бд
        {
            throw new NotImplementedException();
        }

        public void DeleteAllDeceasedsByIdContract(int contractId)      //удалить из бд всех усопших по договору
        {
            throw new NotImplementedException();
        }

        //----------------------
        private void FillDeceasedsPhotoOnMonument(Deceased deceased)
        {
            foreach (PhotoOnMonument p in _photosOnMonumentsRepository.GetAllPhotoOnMonumentsByIdDeceased(deceased.Id))
            {
                deceased.PhotosOnMonument.Add(p);
            }
        }
    }
}