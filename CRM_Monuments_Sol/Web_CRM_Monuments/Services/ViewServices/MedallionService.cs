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

        public MedallionViewModel GetMedallionViewById(int idMedallion)
        {
            MedallionViewModel medallion = new MedallionViewModel();
            if (idMedallion > 0)
            {
                medallion = DBMedallionToView(_dataManager.PhotosOnMonuments.GetMedallionById(idMedallion));
            }
            return medallion;
            //return GetAllMedallionViews().Where(x => x.Medallion.Id == idMedallion).First();
        }
        public MedallionViewModel DBMedallionToView(Medallion m)
        {
            MedallionViewModel medallionView = new MedallionViewModel()
            {
                Medallion = m,
                ContractNumber = m.Deceased.Contract.NumYear + "/" + m.Deceased.Contract.Place + "/" + m.Deceased.Contract.Number,
                DateConclusionContract = m.Deceased.Contract.DateOfConclusion,
                LastNameDeceased = m.Deceased.LastName,
                FirstNameDeceased = m.Deceased.FirstName,
                MiddleNameDeceased = m.Deceased.MiddleName,
                NameCustomer = m.Deceased.Contract.Customers[0].LastName + " " + m.Deceased.Contract.Customers[0].FirstName + " " + m.Deceased.Contract.Customers[0].MiddleName,
                PhoneCustomer = m.Deceased.Contract.Customers[0].Number
            };
            if (m.Deceased.Contract.InstallmentPayment) medallionView.ContractNumber += "р";
            return medallionView;
        }
        public IEnumerable<MedallionViewModel> GetAllMedallionViews()
        {
            List<MedallionViewModel> medallions = new List<MedallionViewModel>();
            foreach (Medallion m in _dataManager.PhotosOnMonuments.GetAllMedallions())
            {
                medallions.Add(DBMedallionToView(m));
            }
            //foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            //{
            //    foreach (Deceased d in c.Deceaseds)
            //    {
            //        foreach (PhotoOnMonument p in d.PhotosOnMonument)
            //        {
            //            if (p is Medallion)
            //            {
            //                medallions.Add(new MedallionViewModel()
            //                {
            //                    Medallion = (Medallion)p,
            //                    ContractNumber = c.NumYear + "/" + c.Place + "/" + c.Number,
            //                    DateConclusionContract = c.DateOfConclusion,
            //                    LastNameDeceased = d.LastName,
            //                    NameCustomer = c.Customers[0].LastName + " " + c.Customers[0].FirstName + " " + c.Customers[0].MiddleName,
            //                    PhoneCustomer = c.Customers[0].Number
            //                });
            //            }
            //        }
            //    }
            //}
            return medallions;
        }
    }
}
