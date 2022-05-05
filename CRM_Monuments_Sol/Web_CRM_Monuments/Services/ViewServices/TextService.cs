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

        //public TextViewModel GetTextNameViewByIdDeceased(int idDeceased)
        //{
        //    return GetAllTextViews().Where(x => x.Deceased.Id == idDeceased && x.TextEpitaph == false).First();
        //}

        //public TextViewModel GetTextEpitaphViewByIdDeceased(int idDeceased)
        //{
        //    return GetAllTextViews().Where(x => x.Deceased.Id == idDeceased && x.TextEpitaph == true).First();
        //}

        public TextViewModel GetTextViewById(int idDeceaced, bool epitaph)
        {
            TextViewModel text = new TextViewModel();
            if (idDeceaced > 0)
            {
                text = DBTextToView(_dataManager.Deceaseds.GetDeceasedById(idDeceaced), epitaph);
            }
            return text;
        }

        public TextViewModel DBTextToView(Deceased d, bool epitaph) 
        {
            TextViewModel text = new TextViewModel()
            {
                Deceased = d,
                ContractNumber = d.Contract.NumYear + "/" + d.Contract.Place + "/" + d.Contract.Number,
                DateConclusionContract = d.Contract.DateOfConclusion,
                NameCustomer = d.Contract.Customers[0].LastName + " " + d.Contract.Customers[0].FirstName + " " + d.Contract.Customers[0].MiddleName,
                PhoneCustomer = d.Contract.Customers[0].Number,
                TextEpitaph = epitaph
            };
            if (text.TextEpitaph)
                text.Engraver = text.Deceased.Epitaph.EngraverEpitaph;
            else text.Engraver = text.Deceased.EngraverName;    
            return text;
        }

        public IEnumerable<TextViewModel> GetAllTextViews()
        {
            List<TextViewModel> texts = new List<TextViewModel>();
            foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            {
                foreach (Deceased d in _dataManager.Deceaseds.GetAllDeceasedsByIdContract(c.Id))
                {
                    if (d.Epitaph.EpitaphBool)
                    {
                        texts.Add(DBTextToView(d, true));
                    }
                    texts.Add(DBTextToView(d, false));
                }
            }
            return texts;
        }
    }
}
