using BuissnesLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Models;

namespace Web_CRM_Monuments.Services.ViewServices
{
    public class TextService
    {
        private DataManager _dataManager;
        public TextService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public TextViewModel GetTextNameByIdDeceased(int idDeceased)
        {
            return GetAllTexts().Where(x => x.Deceased.Id == idDeceased && x.TextEpitaph == false).First();
        }

        public TextViewModel GetTextEpitaphByIdDeceased(int idDeceased)
        {
            return GetAllTexts().Where(x => x.Deceased.Id == idDeceased && x.TextEpitaph == true).First();
        }

        public TextViewModel DBTexttToView(int idDeceaced, bool epitaph)
        {
            TextViewModel text = new TextViewModel();
            if (idDeceaced > 0)
            {
                if (epitaph)
                    text = GetTextEpitaphByIdDeceased(idDeceaced);
                else
                    text = GetTextNameByIdDeceased(idDeceaced);
            }
            return text;
        }

        public IEnumerable<TextViewModel> GetAllTexts()
        {
            List<TextViewModel> texts = new List<TextViewModel>();
            foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            {
                foreach (Deceased d in c.Deceaseds)
                {
                    texts.Add(new TextViewModel()
                    {
                        Deceased = d,
                        ContractNumber = c.NumYear + "/" + c.Place + "/" + c.Number,
                        DateConclusionContract = c.DateOfConclusion,
                        LastNameDeceased = d.LastName,
                        NameCustomer = c.Customers[0].LastName + " " + c.Customers[0].FirstName + " " + c.Customers[0].MiddleName,
                        PhoneCustomer = c.Customers[0].Number,
                        TextEpitaph = false
                    });
                    if (d.Epitaph.EpitaphBool)
                    {
                        texts.Add(new TextViewModel()
                        {
                            Deceased = d,
                            ContractNumber = c.NumYear + "/" + c.Place + "/" + c.Number,
                            DateConclusionContract = c.DateOfConclusion,
                            LastNameDeceased = d.LastName,
                            NameCustomer = c.Customers[0].LastName + " " + c.Customers[0].FirstName + " " + c.Customers[0].MiddleName,
                            PhoneCustomer = c.Customers[0].Number,
                            TextEpitaph = true
                        });
                    }
                }
            }
            return texts;
        }
    }
}
