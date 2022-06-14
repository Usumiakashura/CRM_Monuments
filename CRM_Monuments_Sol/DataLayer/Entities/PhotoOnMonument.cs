using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class PhotoOnMonument
    {   //изображение на памятнике
        public int Id { get; set; }                     //Id
        //[ValidateNever]
        public string? PhotoPath { get; set; }           //Фотография путь
        //[ValidateNever]
        public string? PhotoName { get; set; }           //Фотография имя
        public string? Note { get; set; }                //Примечания
        //public bool DeletedCheck { get; set; }
        public DateTime DateBegin { get; set; }         //Дата Начала выполнения
        public DateTime DateCompleat { get; set; }      //Дата завершения выполнения
        public DateTime DeadLine { get; set; }          //Крайний срок
        //[ValidateNever]
        public int? DeceasedId { get; set; }
        public Deceased Deceased { get; set; }          //для БД
    }
}
