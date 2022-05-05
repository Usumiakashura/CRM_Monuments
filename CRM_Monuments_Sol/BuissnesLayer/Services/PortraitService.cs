using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuissnesLayer.Models;

namespace BuissnesLayer.Services
{
    public class PortraitService
    {
        private DataManager _dataManager;
        public PortraitService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public PortraitViewModel GetPortraitViewById(int idPortrait)
        {
            PortraitViewModel portrait = new PortraitViewModel();
            if (idPortrait > 0)
            {
                portrait = DBPortraitToView(_dataManager.PhotosOnMonuments.GetPortraitById(idPortrait));
            }
            return portrait;
        }

        public IEnumerable<PortraitViewModel> GetAllPortraitViews()
        {
            List<PortraitViewModel> portraits = new List<PortraitViewModel>();
            foreach (Portrait p in _dataManager.PhotosOnMonuments.GetAllPortraits())
            {
                portraits.Add(DBPortraitToView(p));
            }
            
            return portraits;
        }

        public PortraitViewModel DBPortraitToView(Portrait p)
        {
            PortraitViewModel portraitView = new PortraitViewModel()
            {
                Portrait = p,
                ContractNumber = p.Deceased.Contract.NumYear + "/" + p.Deceased.Contract.Place + "/" + p.Deceased.Contract.Number,
                DateConclusionContract = p.Deceased.Contract.DateOfConclusion,
                LastNameDeceased = p.Deceased.LastName,
                FirstNameDeceased = p.Deceased.FirstName,
                MiddleNameDeceased = p.Deceased.MiddleName,
                NameCustomer = p.Deceased.Contract.Customers[0].LastName + " " + p.Deceased.Contract.Customers[0].FirstName + " " + p.Deceased.Contract.Customers[0].MiddleName,
                PhoneCustomer = p.Deceased.Contract.Customers[0].Number
            };
            if (p.Deceased.Contract.InstallmentPayment) portraitView.ContractNumber += "р";
            return portraitView;
        }
    }
}
