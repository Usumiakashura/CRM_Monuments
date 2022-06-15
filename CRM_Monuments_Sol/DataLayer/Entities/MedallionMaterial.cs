using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class MedallionMaterial
    {
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название материала
                
        public List<Medallion> Medallions { get; set; }
        public List<ShapeMedallion> ShapesMedallion { get; set; }
        public List<MedallionSize> MedallionSizes { get; set; }
        public List<MedallionPrice> MedallionPrices { get; set; }
        public MedallionMaterial()
        {
            Medallions = new List<Medallion>();
            ShapesMedallion = new List<ShapeMedallion>();
            MedallionPrices = new List<MedallionPrice>();
        }
    }
}
