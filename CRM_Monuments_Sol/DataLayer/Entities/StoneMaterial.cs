using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class StoneMaterial
    {   //материал камень
        public int Id { get; set; }         //Id
        public string Name { get; set; }    //Название


        public List<StoneAccessorie> StoneAccessories { get; set; }   //для БД
    }
}
