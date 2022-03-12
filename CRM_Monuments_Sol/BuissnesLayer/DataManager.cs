﻿using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IContractsRepository _contractsRepository;
        private ICustomersRepository _customersRepository;
        private IDeceasedsRepository _deceasedsRepository;
        private IPhotosOnMonumentsRepository _photosOnMonumentsRepository;
        private ISelectPointsRepository _selectPointsRepository;
        private IApplicationUsersRepository _applicationUsersRepository;
        private ITypesPortraitRepository _typesPortraitRepository;

        private IEpitaphRepository _epitaphRepository;

        public DataManager(
            IContractsRepository contractsRepository,
            ICustomersRepository customersRepository,
            IDeceasedsRepository deceasedsRepository,
            IPhotosOnMonumentsRepository photosOnMonumentsRepository,
            ISelectPointsRepository selectPointsRepository,
            IApplicationUsersRepository applicationUsersRepository,
            ITypesPortraitRepository typesPortraitRepository,

            IEpitaphRepository epitaphRepository)
        {
            _contractsRepository = contractsRepository;
            _customersRepository = customersRepository;
            _deceasedsRepository = deceasedsRepository;
            _photosOnMonumentsRepository = photosOnMonumentsRepository;
            _selectPointsRepository = selectPointsRepository;
            _applicationUsersRepository = applicationUsersRepository;
            _typesPortraitRepository = typesPortraitRepository;

            _epitaphRepository = epitaphRepository;
        }

        public IContractsRepository Contracts { get { return _contractsRepository; } }
        public ICustomersRepository Customers { get { return _customersRepository; } }
        public IDeceasedsRepository Deceaseds { get { return _deceasedsRepository; } }
        public IPhotosOnMonumentsRepository PhotosOnMonuments { get { return _photosOnMonumentsRepository; } }
        public ISelectPointsRepository SelectPointsRepository { get { return _selectPointsRepository; } }
        public IApplicationUsersRepository ApplicationUsersRepository { get { return _applicationUsersRepository; } }
        public ITypesPortraitRepository TypesPortrait { get { return _typesPortraitRepository; } }

        public IEpitaphRepository Epitaphs { get { return _epitaphRepository; } }
    }
}
