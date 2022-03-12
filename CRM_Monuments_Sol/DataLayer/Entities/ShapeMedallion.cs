using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class ShapeMedallion 
    {
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название

        public List<Medallion> Medallions { get; set; }
        public ShapeMedallion()
        {
            Medallions = new List<Medallion>();
        }
    }
}
