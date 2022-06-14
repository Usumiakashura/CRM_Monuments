using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Stella
    {
        public int Id { get; set; }                     //ID
        public int? ContractId { get; set; }             //ID договора
        public Contract Contract { get; set; }          //сам договор
        public List<Deceased> Deceaseds { get; set; }   //усопшие на стэлле
        
        
        public Stella()
        {
            Deceaseds = new List<Deceased>();
        }

    }
}
