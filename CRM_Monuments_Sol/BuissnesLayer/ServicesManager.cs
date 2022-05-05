using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuissnesLayer.Services;

namespace BuissnesLayer.Services
{
    public class ServicesManager
    {
        private DataManager _dataManager;
        private ContractService _contractService;
        private PortraitService _portraitService;
        private MedallionService _medallionService;
        private TextService _textService;

        public ServicesManager(DataManager dataManager)
        {
            _dataManager = dataManager;
            _contractService = new ContractService(_dataManager);
            _portraitService = new PortraitService(_dataManager);
            _medallionService = new MedallionService(_dataManager);
            _textService = new TextService(_dataManager);
        }

        public ContractService Contracts { get { return _contractService; } }
        public PortraitService Portraits { get { return _portraitService; } }
        public MedallionService Medallions { get { return _medallionService; } }
        public TextService Texts { get { return _textService; } }

    }
}
