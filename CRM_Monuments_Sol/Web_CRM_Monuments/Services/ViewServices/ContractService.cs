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
            int numDeceased;
            foreach (var portrait in contractViewModel.Portraits)
            {
                // Достаем из ключа первую половину номера, относящуюся к номеру контейнера усопшего
                MatchCollection match = Regex.Matches(portrait.Key, @"D(\d+)");
                // Достаем номер этого контейнега
                Int32.TryParse(match[0].Groups[1].ToString(), out numDeceased);
                // Добавляем соответствующему усопшему портрет в коллекцию
                c.Deceaseds[numDeceased].PhotosOnMonument.Add(portrait.Value);
            }
            foreach (var medallion in contractViewModel.Medallions)
            {
                // Достаем из ключа первую половину номера, относящуюся к номеру контейнера усопшего
                MatchCollection match = Regex.Matches(medallion.Key, @"D(\d+)");
                // Достаем номер этого контейнега
                Int32.TryParse(match[0].Groups[1].ToString(), out numDeceased);
                // Добавляем соответствующему усопшему портрет в коллекцию
                c.Deceaseds[numDeceased].PhotosOnMonument.Add(medallion.Value);
            }

            return c;
        }

        public ContractViewModel ModelDBToModelView(Contract contract)
        {
            ContractViewModel cvm = new ContractViewModel();
            cvm.Contract = contract;
            int numPortrait = 0, numMedallion = 0;
            for (int i = 0; i < contract.Deceaseds.Count; i++)
            {
                foreach (PhotoOnMonument ph in contract.Deceaseds[i].PhotosOnMonument)
                {
                    if (ph is Portrait)
                    {
                        cvm.Portraits.Add($"D{i}P{numPortrait}", (Portrait)ph);
                    }
                    else if (ph is Medallion)
                    {
                        cvm.Medallions.Add($"D{i}M{numMedallion}", (Medallion)ph);
                    }
                }

            }
            return cvm;
        }
    }
}
