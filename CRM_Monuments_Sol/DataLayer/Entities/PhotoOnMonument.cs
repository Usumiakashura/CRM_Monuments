﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class PhotoOnMonument
    {   //изображение на памятнике
        public int Id { get; set; }                     //Id
        public string PhotoPath { get; set; }          //Фотография
        public string Note { get; set; }                //Примечания
        public bool DeletedCheck { get; set; }

        public Deceased Deceased { get; set; }          //для БД
    }
}
