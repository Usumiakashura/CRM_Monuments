using BuissnesLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

namespace Web_CRM_Monuments.Services.ViewServices
{
    public class ContractService
    {
        private DataManager _dataManager;
        public ContractService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        
        public Contract ModelViewToModelDB(ContractViewModel contractViewModel)
        {
            Contract c = contractViewModel.Contract;
            List<Deceased> ds = new List<Deceased>();

            foreach (var deceased in contractViewModel.Contract.Deceaseds)
            {
                if (deceased.DateBirthday != null ||
                    deceased.DateRip != null ||
                    deceased.EngraverEpitaph != null ||
                    deceased.EngraverName != null ||
                    deceased.FirstName != null ||
                    deceased.LastName != null ||
                    deceased.MiddleName != null ||
                    deceased.NotesTextName != null)
                {
                    ds.Add(deceased);
                }
            }
            c.Deceaseds = ds;
            int numDeceased;
            foreach (var portrait in contractViewModel.Portraits)
            {
                if (portrait.Value.PhotoImage != null || 
                    portrait.Value.TypePortrait != null ||
                    portrait.Value.Artist != null ||
                    portrait.Value.Note != null)
                {
                    // Достаем из ключа первую половину номера, относящуюся к номеру контейнера усопшего
                    MatchCollection match = Regex.Matches(portrait.Key, @"D(\d+)");
                    // Достаем номер этого контейнега
                    Int32.TryParse(match[0].Groups[1].ToString(), out numDeceased);
                    // Добавляем соответствующему усопшему портрет в коллекцию
                    c.Deceaseds[numDeceased].PhotosOnMonument.Add(portrait.Value);
                }
                
            }
            foreach (var medallion in contractViewModel.Medallions)
            {
                if (medallion.Value.BackgroundMedallion != null ||
                    medallion.Value.ColorFrame != null ||
                    medallion.Value.ColorMedallion != null ||
                    medallion.Value.MaterialMedallion != null ||
                    medallion.Value.Note != null ||
                    medallion.Value.PhotoImage != null ||
                    medallion.Value.ShapeMedallion != null ||
                    medallion.Value.SizeMedallion != null)
                {
                    // Достаем из ключа первую половину номера, относящуюся к номеру контейнера усопшего
                    MatchCollection match = Regex.Matches(medallion.Key, @"D(\d+)");
                    // Достаем номер этого контейнега
                    Int32.TryParse(match[0].Groups[1].ToString(), out numDeceased);
                    // Добавляем соответствующему усопшему портрет в коллекцию
                    c.Deceaseds[numDeceased].PhotosOnMonument.Add(medallion.Value);
                }
            }

            foreach (int numP in contractViewModel.DeletedPhotoIds)
            {
                _dataManager.PhotosOnMonuments.DeletePhotoOnMonument(_dataManager.PhotosOnMonuments.GetPhotoOnMonumentById(numP));
            }
            foreach (int numD in contractViewModel.DeletedDeceasedIds)
            {
                _dataManager.Deceaseds.DeleteDeceased(_dataManager.Deceaseds.GetDeceasedById(numD));
            }
            foreach (int numC in contractViewModel.DeletedCustomerIds)
            {
                _dataManager.Customers.DeleteCustomer(_dataManager.Customers.GetCustomerById(numC));
            }

            return c;
        }

        public ContractViewModel ModelDBToModelView(Contract contract)
        {
            ContractViewModel cvm = new ContractViewModel();
            cvm.Contract = contract;
            int numPortrait, numMedallion;
            for (int i = 0; i < contract.Deceaseds.Count; i++)
            {
                numPortrait = 0; 
                numMedallion = 0;
                foreach (PhotoOnMonument ph in contract.Deceaseds[i].PhotosOnMonument)
                {
                    if (ph is Portrait)
                    {
                        cvm.Portraits.Add($"D{i}P{numPortrait}", (Portrait)ph);
                        numPortrait++;
                    }
                    else if (ph is Medallion)
                    {
                        cvm.Medallions.Add($"D{i}M{numMedallion}", (Medallion)ph);
                        numMedallion++;
                    }
                }

            }
            return cvm;
        }
    }
}
