using BuissnesLayer;
using BuissnesLayer.Implementations;
using BuissnesLayer.Interfaces;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

namespace Web_CRM_Monuments.Services.ViewServices
{
    public class PortraitService
    {
        private DataManager _dataManager;
        public PortraitService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public PortraitViewModel GetPortraitById(int idPortrait)
        {
            return GetAllPortraits().Where(x => x.Portrait.Id == idPortrait).First();

        }

        public IEnumerable<PortraitViewModel> GetAllPortraits()
        {
            List<PortraitViewModel> portraits = new List<PortraitViewModel>();
            foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            {
                foreach (Deceased d in c.Deceaseds)
                {
                    //_dataManager.PhotosOnMonuments.GetAllPhotoOnMonumentsByIdDeceased(d.Id).Where(p => p is Portrait)
                    foreach (Portrait p in d.PhotosOnMonument.Where(p => p is Portrait))
                    {
                        portraits.Add(new PortraitViewModel()
                        {
                            Portrait = p,
                            ContractNumber = c.NumYear + "/" + c.Place + "/" + c.Number,
                            DateConclusionContract = c.DateOfConclusion,
                            LastNameDeceased = d.LastName,
                            NameCustomer = c.Customers[0].LastName + " " + c.Customers[0].FirstName + " " + c.Customers[0].MiddleName,
                            PhoneCustomer = c.Customers[0].Number
                        });
                    }
                }
            }
            return portraits;
        }
    }
}
