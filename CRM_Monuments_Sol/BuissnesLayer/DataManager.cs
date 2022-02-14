using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IAccessorriesRepository _accessorriesRepository;
        private IContractsRepository _contractsRepository;
        private ICustomersRepository _customersRepository;
        private IDeceasedsRepository _deceasedsRepository;
        private IPhotosOnMonumentsRepository _photosOnMonumentsRepository;
        private IStoneMaterialsRepository _stoneMaterialsRepository;

        public DataManager(
            IAccessorriesRepository accessorriesRepository,
            IContractsRepository contractsRepository,
            ICustomersRepository customersRepository,
            IDeceasedsRepository deceasedsRepository,
            IPhotosOnMonumentsRepository photosOnMonumentsRepository,
            IStoneMaterialsRepository stoneMaterialsRepository)
        {
            _accessorriesRepository = accessorriesRepository;
            _contractsRepository = contractsRepository;
            _customersRepository = customersRepository;
            _deceasedsRepository = deceasedsRepository;
            _photosOnMonumentsRepository = photosOnMonumentsRepository;
            _stoneMaterialsRepository = stoneMaterialsRepository;
        }

        public IAccessorriesRepository Accessorries { get { return _accessorriesRepository; } }
        public IContractsRepository Contracts { get { return _contractsRepository; } }
        public ICustomersRepository Customers { get { return _customersRepository; } }
        public IDeceasedsRepository Deceaseds { get { return _deceasedsRepository; } }
        public IPhotosOnMonumentsRepository PhotosOnMonuments { get { return _photosOnMonumentsRepository; } }
        public IStoneMaterialsRepository StoneMaterials { get { return _stoneMaterialsRepository; } }
    }
}
