using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Accessorie
    {   //комплектующие
        public int Id { get; set; }                     //Id
        public string Name { get; set; }                //Название
        public int Number { get; set; }                 //количество
        public string Note { get; set; }                //примечания


        public Contract Contract { get; set; }          //для БД


    }
}
