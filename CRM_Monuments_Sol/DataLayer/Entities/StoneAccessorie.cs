using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class StoneAccessorie : Accessorie
    {   //комплектующие из камня
        public StoneMaterial Material { get; set; }     //Материал
        public int StoneId { get; set; }
        public int Height { get; set; }                 //высота
        public int Width { get; set; }                  //ширина
        public int Thickness { get; set; }              //толщина

    }
}
