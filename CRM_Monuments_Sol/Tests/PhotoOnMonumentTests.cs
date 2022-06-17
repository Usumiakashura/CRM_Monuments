using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Implementations;
using DataLayer.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    class PhotoOnMonumentTests
    {
        private IPhotosOnMonumentsRepository photosOnMonumentsRepository;
        private void GetRepositoryes(EFDBContext context)
        {
            photosOnMonumentsRepository = new EFPhotosOnMonumentsRepository(context);
        }

        [Test]
        public void GetAllPhotosOnMonumentsByIdDeceasedTest()
        {
            List<PhotoOnMonument> photos = new List<PhotoOnMonument>();
            using (EFDBContext context = new EFDBContext())
            {
                // arrange (организация)
                GetRepositoryes(context);
                //act(акт)
                photos = photosOnMonumentsRepository.GetAllPhotoOnMonumentsByIdDeceased(1).ToList();
                //assert(утверждение)
                Assert.IsTrue(photos[0] is Portrait);
            }
        }
    }
}
