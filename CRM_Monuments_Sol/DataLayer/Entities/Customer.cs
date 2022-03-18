using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Customer
    {   //заказчик
        public int Id { get; set; }                 //Id
        public string? LastName { get; set; }        //Фамилия
        [Required(ErrorMessage ="Укажите имя заказчика")]
        public string FirstName { get; set; }       //Имя
        public string? MiddleName { get; set; }      //Отчество
        [EmailAddress]
        public string? Email { get; set; }           //Почта
        [Required(ErrorMessage = "Укажите номер телефона")]
        [Phone]
        public string? Number { get; set; }          //Номер телефона
        public bool Viber { get; set; }             //Наличие мессенджера
        public bool Telegram { get; set; }          //Наличие мессенджера
        public bool WhatsApp { get; set; }          //Наличие мессенджера
        [Required(ErrorMessage = "Укажите адрес заказчика")]
        public string Address { get; set; }         //Адрес заказчика
        public string? Note { get; set; }            //Примечания
        //public bool DeletedCheck { get; set; }

        [ValidateNever]
        public Contract Contract { get; set; }      //для БД
    }
}
