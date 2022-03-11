using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.Interfaces
{
    public interface ITypesPortraitRepository
    {
        public IEnumerable<TypePortrait> GetAllTypesPortraits();
        public TypePortrait GetTypePortraitById(int idTypePortrait);
        public TypePortrait GetTypePortraitByIdPortrait(int idPortrait);
    }
}
