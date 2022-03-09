using DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_CRM_Monuments.Models
{
    public class ContractViewModel
    {
        public Contract Contract { get; set; }

        public List<PhotoViewModel> Photos { get; set; }
        //public List<PhotoViewModel> PortraitPhotos { get; set; }
        //public List<PhotoViewModel> MedallionPhotos { get; set; }

        public Dictionary<string, Portrait> Portraits { get; set; }
        public Dictionary<string, Medallion> Medallions { get; set; }

        public List<int> DeletedDeceasedIds { get; set; }
        public List<int> DeletedPhotoIds { get; set; }
        public List<int> DeletedCustomerIds { get; set; }

        public int PhotoCounter { get; set; } 


        public ContractViewModel()
        {
            Contract = new Contract()
            {
                //Id = -1,
                DateOfConclusion = DateTime.Today,
                DeadLine = DateTime.Today.AddDays(90),
                NumYear = (DateTime.Today.Year.ToString()).Substring(2),
                Place = "ДО"
            };
            Contract.Customers.Add(new Customer() { Id = -1 });

            Portraits = new Dictionary<string, Portrait>();
            Medallions = new Dictionary<string, Medallion>();
            DeletedDeceasedIds = new List<int>();
            DeletedPhotoIds = new List<int>();
            DeletedCustomerIds = new List<int>();
        }

        
    }
}
