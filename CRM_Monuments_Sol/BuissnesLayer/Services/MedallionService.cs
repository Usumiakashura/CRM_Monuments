using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuissnesLayer.Models;

namespace BuissnesLayer.Services
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
                //Medallion = m,
                //ContractNumber = m.Deceased.Contract.NumYear + "/" + m.Deceased.Contract.Place + "/" + m.Deceased.Contract.Number,
                //DateConclusionContract = m.Deceased.Contract.DateOfConclusion,
                //LastNameDeceased = m.Deceased.LastName,
                //FirstNameDeceased = m.Deceased.FirstName,
                //MiddleNameDeceased = m.Deceased.MiddleName,
                //NameCustomer = m.Deceased.Contract.Customers[0].LastName + " " + m.Deceased.Contract.Customers[0].FirstName + " " + m.Deceased.Contract.Customers[0].MiddleName,
                //PhoneCustomer = m.Deceased.Contract.Customers[0].Number
            };
            //if (m.Deceased.Contract.InstallmentPayment) medallionView.ContractNumber += "р";
            return medallionView;
        }
        public IEnumerable<MedallionViewModel> GetAllMedallionViews()
        {
            List<MedallionViewModel> medallions = new List<MedallionViewModel>();
            foreach (Medallion m in _dataManager.PhotosOnMonuments.GetAllMedallions())
            {
                medallions.Add(DBMedallionToView(m));
            }
            return medallions;
        }
    }
}
