using BuissnesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_CRM_Monuments.Services.ViewServices;

namespace Web_CRM_Monuments.Services
{
    public class ServicesManager
    {
        private DataManager _dataManager;
        private ContractService _contractService;
        private PortraitService _portraitService;

        public ServicesManager(DataManager dataManager)
        {
            _dataManager = dataManager;
            _contractService = new ContractService(_dataManager);
            _portraitService = new PortraitService(_dataManager);
        }

        public ContractService Contracts { get { return _contractService; } }
        public PortraitService Portraits { get { return _portraitService; } }

    }
}
