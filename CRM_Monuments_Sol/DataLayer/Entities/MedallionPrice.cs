using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class MedallionPrice
    {
        public int? MedallionSizeId { get; set; }                   //размер медальона
        public MedallionSize MedallionSize { get; set; }

        public int? MedallionMaterialId { get; set; }               //материал медальона
        public MedallionMaterial MedallionMaterial { get; set; } 

        public decimal Price { get; set; }      //цена

    }
}
