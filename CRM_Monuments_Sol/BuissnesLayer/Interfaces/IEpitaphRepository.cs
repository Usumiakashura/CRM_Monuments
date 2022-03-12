﻿using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface IEpitaphRepository
    {

        public Epitaph GetEpitaphByIdDeceased(int idDeceased);
        public void SaveEpitaph(Epitaph epitaph);
        public void DeleteEpitaph(Epitaph epitaph);
        public void CompleateOnTextEpitaph(int idDeceaced, DateTime dateCompleate);
    }
}
