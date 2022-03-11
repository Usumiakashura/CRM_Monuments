using BuissnesLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

namespace Web_CRM_Monuments.Services.ViewServices
{
    public class MedallionService
    {
        private DataManager _dataManager;
        public MedallionService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public MedallionViewModel GetMedallionById(int idMedallion)
        {
            return GetAllMedallions().Where(x => x.Medallion.Id == idMedallion).First();

        }

        public IEnumerable<MedallionViewModel> GetAllMedallions()
        {
            List<MedallionViewModel> medallions = new List<MedallionViewModel>();
            foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            {
                foreach (Deceased d in c.Deceaseds)
                {
                    foreach (PhotoOnMonument p in d.PhotosOnMonument)
                    {
                        if (p is Medallion)
                        {
                            medallions.Add(new MedallionViewModel()
                            {
                                Medallion = (Medallion)p,
                                ContractNumber = c.NumYear + "/" + c.Place + "/" + c.Number,
                                DateConclusionContract = c.DateOfConclusion,
                                LastNameDeceased = d.LastName,
                                NameCustomer = c.Customers[0].LastName + " " + c.Customers[0].FirstName + " " + c.Customers[0].MiddleName,
                                PhoneCustomer = c.Customers[0].Number
                            });
                        }
                    }
                }
            }
            return medallions;
        }
    }
}
