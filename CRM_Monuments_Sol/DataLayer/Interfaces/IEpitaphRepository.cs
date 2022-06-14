using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IEpitaphRepository
    {
        public IEnumerable<Epitaph> GetAllEpitaphsByIdDeceased(int idDeceased);
        public Epitaph GetEpitaphById(int idEpitaph);
        public void SaveEpitaph(Epitaph epitaph);
        public void DeleteEpitaph(Epitaph epitaph);
        public void DeleteAllEpitaphsByIdDeceased(int deceasedId);
        public void CompleateOnTextEpitaph(int idEpitaph, DateTime dateCompleate);
    }
}
