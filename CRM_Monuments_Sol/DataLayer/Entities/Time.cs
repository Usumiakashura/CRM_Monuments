using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Time
    {
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название срока
        public int DurationDay { get; set; }            //Продолжительность
    }
}
