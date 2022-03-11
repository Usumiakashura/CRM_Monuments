using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TypePortrait
    {
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название

        public List<Portrait> Portraits { get; set; }

        public TypePortrait()
        {
            Portraits = new List<Portrait>();
        }
    }
}
