using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TypeText
    {
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название

        //public List<Deceased> Deceaseds { get; set; }
        public List<Epitaph> Epitaphs { get; set; }
        public List<TextOnStella> TextOnStellas { get; set; }

        public TypeText()
        {
            //Deceaseds = new List<Deceased>();
            Epitaphs = new List<Epitaph>();
            TextOnStellas = new List<TextOnStella>();
        }

    }
}
