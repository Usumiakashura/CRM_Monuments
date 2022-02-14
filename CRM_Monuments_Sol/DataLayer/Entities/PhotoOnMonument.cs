using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class PhotoOnMonument
    {   //изображение на памятнике
        public int Id { get; set; }                     //Id
        public byte[] PhotoImage { get; set; }          //Фотография
        public string Note { get; set; }                //Примечания


        public Deceased Deceased { get; set; }          //для БД
        public Contract Contract { get; set; }          //для БД
    }
}
