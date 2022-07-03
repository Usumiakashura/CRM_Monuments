using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewModels
{
    public class PortraitViewModel
    {
        public int Id { get; set; }                     //Id
        public string? PhotoPath { get; set; }          //Фотография путь
        public string? PhotoName { get; set; }          //Фотография имя
        public string? Note { get; set; }               //Примечания
        public DateTime DateBegin { get; set; }         //Дата Начала выполнения
        public DateTime DateCompleat { get; set; }      //Дата завершения выполнения
        public DateTime DeadLine { get; set; }          //Крайний срок
        public int? DeceasedId { get; set; }

        public List<PhotoViewModel> Photos { get; set; }
        //-------------------------------------------------------
        //-------------------------------------------------------
        public string? Artist { get; set; }                 //художник
        public int? TypePortraitId { get; set; }            //тип портрета Id
    }
}
