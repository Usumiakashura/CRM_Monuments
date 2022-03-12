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
    public class EFTypesPortraitRepository : ITypesPortraitRepository
    {
        private EFDBContext _context;
        private EFPhotosOnMonumentsRepository _photosOnMonumentsRepository;

        public EFTypesPortraitRepository(EFDBContext context)
        {
            _context = context;
            _photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(_context);
        }
        
        public IEnumerable<TypePortrait> GetAllTypesPortraits()
        {
            return _context.TypePortraits.Include(tp => tp.Portraits);
        }

        //public TypePortrait GetTypePortraitById(int idTypePortrait)
        //{
        //    return _context.TypePortraits.Include(tp => tp.Portraits).Where(tp => tp.Id == idTypePortrait).First();
        //}

        public TypePortrait GetTypePortraitByName(string nameTypePortrait)
        {
            return _context.TypePortraits.Include(tp => tp.Portraits).Where(tp => tp.Name == nameTypePortrait).First();
        }

        //public TypePortrait GetTypePortraitByIdPortrait(int idPortrait)
        //{
        //    TypePortrait type = new TypePortrait();
        //    var portraits = GetAllTypesPortraits();
        //    foreach (var tp in portraits)
        //    {
        //        if (tp.Portraits.Where(p => p.Id == idPortrait).First() != null)
        //            type = tp;
        //    }
        //    return type;

        //    //int typeId = _photosOnMonumentsRepository.GetAllPortraits().Where(p => p.Id == idPortrait).First().TypePortraitId;
        //    //return GetTypePortraitById(typeId);
        //}

        //public int GetIdTypeByName(string name)
        //{
        //    return (_context.TypePortraits.Where(tp => tp.Name == name).First()).Id;
        //}
    }
}