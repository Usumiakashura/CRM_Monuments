using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class TextOnStella
    {
        [Key]
        [ForeignKey("Deceased")]
        public int Id { get; set; }
        public string? LastName { get; set; }                       //Фамилия
        public string? FirstName { get; set; }                      //Имя
        public string? MiddleName { get; set; }                     //Отчество
        public DateTime DateBirthday { get; set; }                  //Дата рождения
        public DateTime DateRip { get; set; }                       //Дата смерти

        public int? TypeTextId { get; set; }
        [ValidateNever]
        public TypeText TypeText { get; set; }                      //тип текста на памятнике

        [ValidateNever]
        public string? NotesTextName { get; set; }                  //примечания к тексту
        public string? EngraverName { get; set; }                   //резчик текста
        public DateTime DateBeginTextOnStella { get; set; }         //Дата Начала выполнения текста ФИО
        public DateTime DateCompleatTextOnStella { get; set; }      //Дата завершения выполнения текста ФИО
        public DateTime DeadLine { get; set; }                      //Крайний срок выполнения текста



        public Deceased Deceased { get; set; }                      //для бд
    }
}
