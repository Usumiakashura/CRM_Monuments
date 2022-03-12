using BuissnesLayer;
using BuissnesLayer.Implementations;
using BuissnesLayer.Interfaces;
using DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

namespace Web_CRM_Monuments.Services.ViewServices
{
    public class ContractService
    {
        private DataManager _dataManager;
        //private IHostingEnvironment _hostingEnvironment;
        public ContractService(DataManager dataManager/*, IHostingEnvironment hostingEnvironment*/)
        {
            _dataManager = dataManager;
            //_hostingEnvironment = hostingEnvironment;
        }

        public string NewContractNumber()
        {
            return _dataManager.Contracts.NewNumber();
        }

        public void SaveViewModelToDB(ContractViewModel contractViewModel)
        {
            Contract c = ModelViewToModelDB(contractViewModel);


            foreach (int numP in contractViewModel.DeletedPhotoIds)
            {
                if (numP > 0) 
                    _dataManager.PhotosOnMonuments.DeletePhotoOnMonument(_dataManager.PhotosOnMonuments.GetPhotoOnMonumentById(numP));
            }
            foreach (int numD in contractViewModel.DeletedDeceasedIds)
            {
                if (numD > 0) 
                    _dataManager.Deceaseds.DeleteDeceased(_dataManager.Deceaseds.GetDeceasedById(numD));
            }
            foreach (int numC in contractViewModel.DeletedCustomerIds)
            {
                if (numC > 0) 
                    _dataManager.Customers.DeleteCustomer(_dataManager.Customers.GetCustomerById(numC));
            }
            _dataManager.Contracts.SaveContract(c);
        }
        public Contract ModelViewToModelDB(ContractViewModel contractViewModel)
        {
            Contract c = contractViewModel.Contract;
            //if (c.Id == -1) c.Id = 0;
            List<Customer> customers = new List<Customer>();
            List<Deceased> deceaseds = new List<Deceased>();

            foreach (var customer in contractViewModel.Contract.Customers)
            {
                if (customer.Id != 0)
                {
                    if (customer.Id == -1) customer.Id = 0;
                    customers.Add(customer);
                }
            }
            foreach (var deceased in contractViewModel.Contract.Deceaseds)
            {
                if (deceased.Id != 0)
                {
                    if (deceased.Id == -1) deceased.Id = 0;
                    deceaseds.Add(deceased);
                }
            }
            c.Customers = customers;
            c.Deceaseds = deceaseds;

            


            int numDeceased;
            foreach (var portrait in contractViewModel.Portraits)
            {
                if (portrait.Value.Id != 0)
                {
                    if (portrait.Value.Id == -1) portrait.Value.Id = 0;
                    portrait.Value.TypePortrait = new TypePortrait()
                    {
                        Id = _dataManager.TypesPortrait.GetIdTypeByName(portrait.Value.TypePortraitName),
                        Name = portrait.Value.TypePortraitName
                    };
                    portrait.Value.TypePortrait = _dataManager.TypesPortrait.GetTypePortraitByName(portrait.Value.TypePortraitName);
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
                if (medallion.Value.Id != 0)
                {
                    if (medallion.Value.Id == -1) medallion.Value.Id = 0;
                    // Достаем из ключа первую половину номера, относящуюся к номеру контейнера усопшего
                    MatchCollection match = Regex.Matches(medallion.Key, @"D(\d+)");
                    // Достаем номер этого контейнега
                    Int32.TryParse(match[0].Groups[1].ToString(), out numDeceased);
                    // Добавляем соответствующему усопшему портрет в коллекцию
                    c.Deceaseds[numDeceased].PhotosOnMonument.Add(medallion.Value);
                }
            }

            
            return c;
        }
        public ContractViewModel ModelDBToModelView(Contract contract)
        {
            ContractViewModel cvm = new ContractViewModel();
            cvm.Contract = contract;
            int numDeceased, numPortrait, numMedallion;
            foreach (Deceased d in _dataManager.Deceaseds.GetAllDeceasedsByIdContract(contract.Id))
            {
                numDeceased = 0;
                numPortrait = 0;
                numMedallion = 0;
                foreach (PhotoOnMonument ph in d.PhotosOnMonument)
                {
                    if (ph is Portrait)
                    {
                        cvm.Portraits.Add($"D{numDeceased}P{numPortrait}", (Portrait)ph);
                        numPortrait++;
                    }
                    else if (ph is Medallion)
                    {
                        cvm.Medallions.Add($"D{numDeceased}M{numMedallion}", (Medallion)ph);
                        numMedallion++;
                    }
                }
                numDeceased++;
            }


            //for (int i = 0; i <  contract.Deceaseds.Count; i++)
            //{
            //    numPortrait = 0; 
            //    numMedallion = 0;
            //    foreach (PhotoOnMonument ph in contract.Deceaseds[i].PhotosOnMonument)
            //    {
            //        if (ph is Portrait)
            //        {
            //            cvm.Portraits.Add($"D{i}P{numPortrait}", (Portrait)ph);
            //            numPortrait++;
            //        }
            //        else if (ph is Medallion)
            //        {
            //            cvm.Medallions.Add($"D{i}M{numMedallion}", (Medallion)ph);
            //            numMedallion++;
            //        }

            //        //cvm.Photos.Add(new PhotoViewModel() { Image = new IFormFile() })
            //    }

            //}

            return cvm;
        }
    }
}
