using DataLayer;
using DataLayer.Context;
using DataLayer.Entities;
using DataLayer.Implementations;
using DataLayer.Interfaces;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    class ContractsRepositoryTests
    {
        private IContractsRepository contractsRepository;
        private void GetRepositoryes(EFDBContext context)
        {
            contractsRepository = new EFContractsRepository(context);
        }

        [Test]
        public void GetContractByIdTest()
        {
            
            Contract contract;
            using (EFDBContext context = new EFDBContext())
            {
                // arrange (организация)
                GetRepositoryes(context);
                //act(акт)
                contract = contractsRepository.GetContractById(1);
                //assert(утверждение)
                Assert.IsTrue(contract.Customers.Count > 0);
            }
        }

    }
}
