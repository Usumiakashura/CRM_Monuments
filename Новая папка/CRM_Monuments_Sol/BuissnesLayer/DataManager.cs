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
        private ISelectPointsRepository _selectPointsRepository;
        private IApplicationUsersRepository _applicationUsersRepository;
        private ITypesPortraitRepository _typesPortraitRepository;

        public DataManager(
            IAccessorriesRepository accessorriesRepository,
            IContractsRepository contractsRepository,
            ICustomersRepository customersRepository,
            IDeceasedsRepository deceasedsRepository,
            IPhotosOnMonumentsRepository photosOnMonumentsRepository,
            IStoneMaterialsRepository stoneMaterialsRepository,
            ISelectPointsRepository selectPointsRepository,
            IApplicationUsersRepository applicationUsersRepository,
            ITypesPortraitRepository typesPortraitRepository)
        {
            _accessorriesRepository = accessorriesRepository;
            _contractsRepository = contractsRepository;
            _customersRepository = customersRepository;
            _deceasedsRepository = deceasedsRepository;
            _photosOnMonumentsRepository = photosOnMonumentsRepository;
            _stoneMaterialsRepository = stoneMaterialsRepository;
            _selectPointsRepository = selectPointsRepository;
            _applicationUsersRepository = applicationUsersRepository;
            _typesPortraitRepository = typesPortraitRepository;
        }

        public IAccessorriesRepository Accessorries { get { return _accessorriesRepository; } }
        public IContractsRepository Contracts { get { return _contractsRepository; } }
        public ICustomersRepository Customers { get { return _customersRepository; } }
        public IDeceasedsRepository Deceaseds { get { return _deceasedsRepository; } }
        public IPhotosOnMonumentsRepository PhotosOnMonuments { get { return _photosOnMonumentsRepository; } }
        public IStoneMaterialsRepository StoneMaterials { get { return _stoneMaterialsRepository; } }
        public ISelectPointsRepository SelectPointsRepository { get { return _selectPointsRepository; } }
        public IApplicationUsersRepository ApplicationUsersRepository { get { return _applicationUsersRepository; } }
        public ITypesPortraitRepository TypesPortrait { get { return _typesPortraitRepository; } }
    }
}
