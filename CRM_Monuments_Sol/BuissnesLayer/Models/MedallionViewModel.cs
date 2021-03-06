using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuissnesLayer.Models
{
    public class MedallionViewModel
    {
        public Medallion Medallion { get; set; }
        public string ContractNumber { get; set; }
        public DateTime DateConclusionContract { get; set; }
        public string LastNameDeceased { get; set; }
        public string FirstNameDeceased { get; set; }
        public string MiddleNameDeceased { get; set; }
        public string NameCustomer { get; set; }
        public string PhoneCustomer { get; set; }
        //public DateTime DateExecutionContract { get; set; }
    }
}
