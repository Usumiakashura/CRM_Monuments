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

        public List<int> DeletedDeceasedIds { get; set; }
        public List<int> DeletedPhotoIds { get; set; }
        public List<int> DeletedCustomerIds { get; set; }

        public ContractViewModel()
        {
            Portraits = new Dictionary<string, Portrait>();
            Medallions = new Dictionary<string, Medallion>();
            DeletedDeceasedIds = new List<int>();
            DeletedPhotoIds = new List<int>();
            DeletedCustomerIds = new List<int>();
        }

        
    }
}
