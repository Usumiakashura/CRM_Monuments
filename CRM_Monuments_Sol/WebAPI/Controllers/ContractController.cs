using BuissnesLayer.Services;
using BuissnesLayer.ViewModels;
using DataLayer;
using DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContractController : ControllerBase
    {
        private DataManager _dataManager;
        private ServicesManager _servicesManager;

        public ContractController(DataManager dataManager)
        {
            _dataManager = dataManager;
            _servicesManager = new ServicesManager(_dataManager);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContractViewModel>>> Get()
        {
            return await Task.Run(() => _servicesManager.ContractsView.GetAllContracts().ToList()); //_dataManager.MedallionMaterials.GetAllMedallionsMaterials().ToList());
        }
        //public string Get()
        //{
        //    string json = JsonSerializer.Serialize(_dataManager.Contracts.GetAllContracts());
        //    return json;
        //}
    }
}
