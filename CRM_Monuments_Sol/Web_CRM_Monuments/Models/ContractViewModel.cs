using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_CRM_Monuments.Models
{
    public class ContractViewModel
    {
        public Contract Contract { get; set; }
        

        public Dictionary<string, Portrait> Portraits { get; set; }
        public Dictionary<string, Medallion> Medallions { get; set; }
        public ContractViewModel()
        {
            Portraits = new Dictionary<string, Portrait>();
            Medallions = new Dictionary<string, Medallion>();
        }

        
    }
}
