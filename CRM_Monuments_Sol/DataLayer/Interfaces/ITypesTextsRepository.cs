using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface ITypesTextsRepository
    {
        public IEnumerable<TypeText> GetAllTypesText();
        public void SaveTypeText(TypeText typeText);
        public void DeleteTypeText(TypeText typeText);
    }
}
