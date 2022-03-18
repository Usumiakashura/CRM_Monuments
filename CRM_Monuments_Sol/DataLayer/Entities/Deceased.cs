using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Deceased
    {   //усопший
        public int Id { get; set; }                     //Id
        public string? LastName { get; set; }            //Фамилия
        public string? FirstName { get; set; }           //Имя
        public string? MiddleName { get; set; }          //Отчество
        public DateTime DateBirthday { get; set; }      //Дата рождения
        public DateTime DateRip { get; set; }           //Дата смерти
        
        //--- Фотография/портрет на памятнике ---
        public bool Photo { get; set; }                 //без/с фото
        public List<PhotoOnMonument> PhotosOnMonument { get; set; }    //обработка фотографий на памятнике

        //---------------------------------------

        //--- Текст на памятнике ---
        public int? TypeTextObjId { get; set; }
        [ValidateNever]
        public TypeText TypeTextObj { get; set; }      //тип текста на памятнике (имя)
        //public string TypeNameText { get; set; }
        //public TypeText TypeTextName { get; set; }
        [ValidateNever]
        public string? NotesTextName { get; set; }       //примечания к тексту (имя)
        public string? EngraverName { get; set; }      //резчик текста (имя)
        
        public Epitaph Epitaph { get; set; }
        //--------------------------
        //public bool DeletedCheck { get; set; }
        public DateTime DateBeginTextName { get; set; }         //Дата Начала выполнения текста ФИО
        public DateTime DateCompleatTextName { get; set; }      //Дата завершения выполнения текста ФИО
        //public DateTime DateBeginTextEpitaph { get; set; }         //Дата Начала выполнения текста эпитафии
        //public DateTime DateCompleatTextEpitaph { get; set; }      //Дата завершения выполнения текста эпитафии

        public DateTime DeadLine { get; set; }          //Крайний срок
        [ValidateNever]
        public Contract Contract { get; set; }          //для бд


        public Deceased()
        {
            PhotosOnMonument = new List<PhotoOnMonument>();
        }
    }
}
