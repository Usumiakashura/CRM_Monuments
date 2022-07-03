using AutoMapper;
using BuissnesLayer.ViewModels;
using DataLayer;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewServices
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

        public IEnumerable<ContractViewModel> GetAllContracts()
        {
            List<ContractViewModel> allContracts = new List<ContractViewModel>();
            foreach (Contract c in _dataManager.Contracts.GetAllContracts())
            {
                allContracts.Add(ModelDBToModelView(c));
            }
            
            return allContracts;
        }

        public ContractViewModel GetContractViewById(int idContract)
        {
            return ModelDBToModelView(_dataManager.Contracts.GetContractById(idContract));
        }

        public string NewContractNumber()
        {
            return _dataManager.Contracts.NewNumber();
        }

        public void SaveViewModelToDB(ContractViewModel contractViewModel)
        {
            Contract c = ModelViewToModelDB(contractViewModel);
            //foreach (int numP in contractViewModel.DeletedPhotoIds)
            //{
            //    if (numP > 0)
            //        _dataManager.PhotosOnMonuments.DeletePhotoOnMonument(_dataManager.PhotosOnMonuments.GetPhotoOnMonumentById(numP));
            //}
            //foreach (int numD in contractViewModel.DeletedDeceasedIds)
            //{
            //    if (numD > 0)
            //        _dataManager.Deceaseds.DeleteDeceased(_dataManager.Deceaseds.GetDeceasedById(numD));
            //}
            //foreach (int numC in contractViewModel.DeletedCustomerIds)
            //{
            //    if (numC > 0)
            //        _dataManager.Customers.DeleteCustomer(_dataManager.Customers.GetCustomerById(numC));
            //}
            _dataManager.Contracts.SaveContract(c);
        }

        //---------------------------------------------------
        //-------------- Private functions ------------------
        //---------------------------------------------------
        private Contract ModelViewToModelDB(ContractViewModel contractViewModel)
        {
            Contract c = new Contract();
            


            return c;
        }

        private ContractViewModel ModelDBToModelView(Contract contract)
        {
            ContractViewModel cvm = new ContractViewModel();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Contract, ContractViewModel>();
                cfg.CreateMap<Customer, CustomerViewModel>();
                cfg.CreateMap<Stella, StellaViewModel>();
                cfg.CreateMap<Deceased, DeceasedViewModel>();
                cfg.CreateMap<TextOnStella, TextOnStellaViewModel>();
                cfg.CreateMap<Epitaph, EpitaphViewModel>();
                cfg.CreateMap<Portrait, PortraitViewModel>();
                cfg.CreateMap<Medallion, MedallionViewModel>();
            });
            var mapper = new Mapper(config);
            cvm = mapper.Map<Contract, ContractViewModel>(contract);

            return cvm;
        }
    }
}
