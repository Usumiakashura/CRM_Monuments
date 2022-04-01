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
        public void SaveTypePortrait(TypePortrait typePortrait);
        public void DeleteTypePortrait(TypePortrait typePortrait);

    }
}
