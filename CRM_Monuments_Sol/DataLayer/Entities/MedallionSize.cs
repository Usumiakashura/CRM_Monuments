using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class MedallionSize
    {
        public int Id { get; set; }                     //Id
        public string Size { get; set; }                //Размер

        public List<MedallionMaterial> MedallionMaterials { get; set; }
        public List<MedallionPrice> MedallionPrices { get; set; }
        public List<Medallion> Medallions { get; set; }
        public MedallionSize()
        {
            Medallions = new List<Medallion>();
            MedallionPrices = new List<MedallionPrice>();
        }
    }
}
