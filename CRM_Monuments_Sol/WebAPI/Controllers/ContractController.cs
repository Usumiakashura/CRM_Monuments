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

        public ContractController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ColorMedallion>>> Get()
        {
            return await Task.Run(() => _dataManager.ColorMedallions.GetAllColorsMedallions().ToList());
        }
        //public string Get()
        //{
        //    string json = JsonSerializer.Serialize(_dataManager.Contracts.GetAllContracts());
        //    return json;
        //}
    }
}
