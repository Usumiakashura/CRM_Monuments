using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        private IContractsRepository _contractsRepository;
        private ICustomersRepository _customersRepository;
        private IDeceasedsRepository _deceasedsRepository;
        private IPhotosOnMonumentsRepository _photosOnMonumentsRepository;
        private IApplicationUsersRepository _applicationUsersRepository;
        private ITypesPortraitRepository _typesPortraitRepository;
        private ITypesTextsRepository _typesTextsRepository;
        private IMedallionMaterialsRepository _medallionMaterialsRepository;
        private IShapeMedallionsRepository _shapeMedallionsRepository;
        private IEpitaphRepository _epitaphRepository;
        private IStellaRepository _stellaRepository;
        private ITextOnStellaRepository _textOnStellaRepository;

        public DataManager(
            IContractsRepository contractsRepository,
            ICustomersRepository customersRepository,
            IDeceasedsRepository deceasedsRepository,
            IPhotosOnMonumentsRepository photosOnMonumentsRepository,
            IApplicationUsersRepository applicationUsersRepository,
            ITypesPortraitRepository typesPortraitRepository,
            ITypesTextsRepository typesTextsRepository,
            IMedallionMaterialsRepository medallionMaterialsRepository,
            IShapeMedallionsRepository shapeMedallionsRepository,
            IStellaRepository stellaRepository,
            ITextOnStellaRepository textOnStellaRepository,
            IEpitaphRepository epitaphRepository)
        {
            _contractsRepository = contractsRepository;
            _customersRepository = customersRepository;
            _deceasedsRepository = deceasedsRepository;
            _photosOnMonumentsRepository = photosOnMonumentsRepository;
            _applicationUsersRepository = applicationUsersRepository;
            _typesPortraitRepository = typesPortraitRepository;
            _typesTextsRepository = typesTextsRepository;
            _medallionMaterialsRepository = medallionMaterialsRepository;
            _shapeMedallionsRepository = shapeMedallionsRepository;
            _epitaphRepository = epitaphRepository;
            _stellaRepository = stellaRepository;
            _textOnStellaRepository = textOnStellaRepository;
        }

        public IContractsRepository Contracts { get { return _contractsRepository; } }
        public ICustomersRepository Customers { get { return _customersRepository; } }
        public IDeceasedsRepository Deceaseds { get { return _deceasedsRepository; } }
        public IPhotosOnMonumentsRepository PhotosOnMonuments { get { return _photosOnMonumentsRepository; } }
        public IApplicationUsersRepository ApplicationUsersRepository { get { return _applicationUsersRepository; } }
        public ITypesPortraitRepository TypesPortrait { get { return _typesPortraitRepository; } }
        public ITypesTextsRepository TypesTexts { get { return _typesTextsRepository; } }
        public IMedallionMaterialsRepository MedallionMaterials { get { return _medallionMaterialsRepository; } }
        public IShapeMedallionsRepository ShapeMedallions { get { return _shapeMedallionsRepository; } }
        public IEpitaphRepository Epitaphs { get { return _epitaphRepository; } }
        public IStellaRepository Stellas { get { return _stellaRepository; } }
        public ITextOnStellaRepository TextsOnStella { get { return _textOnStellaRepository; } }
    }
}
