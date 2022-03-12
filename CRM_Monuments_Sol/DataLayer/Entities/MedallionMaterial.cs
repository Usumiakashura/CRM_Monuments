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
        public string Name { get; set; }                //Название

        public List<Medallion> Medallions { get; set; }
        public MedallionMaterial()
        {
            Medallions = new List<Medallion>();
        }
    }
}
