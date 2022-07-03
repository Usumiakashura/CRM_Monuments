using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Contract
    {   
        public int Id { get; set; }                     //Id
        public DateTime DateOfConclusion { get; set; }  //Дата заключения

        //--- Номер договора (составной) ---
        
        public string? NumYear { get; set; }             //часть, отвечающая за год
        public string? Place { get; set; }               //часть, отвечающая за офис (аббревиатура)
        public string? Number { get; set; }              //часть с номером (цифры, но может быть и БН)
        public bool InstallmentPayment { get; set; }     //рассрочка (добавляется буква "р" в конец)
        //----------------------------------

        public List<Customer> Customers { get; set; }   //Все заказчики и их контакты

        //--- Место захоронения ---
        public bool Pickup { get; set; }                //Самовывоз (да/нет)
        public string? BurialAddress { get; set; }       //место захоронения
        public int? Row { get; set; }                    //ряд
        public int? BurialPlace { get; set; }            //место
        public int? Sector { get; set; }                 //сектор
        public int? Grave { get; set; }                  //могила
        public int? DistanceFromMKAD { get; set; }       //расстояние от МКАД
        public int? NumberOfTrips { get; set; }          //количество выездов

        //-------------------------

        public DateTime DeadLine { get; set; }          //Срок выполнения заказа

        //-------------------------

        public List<Stella> Stellas { get; set; }       //стеллы

        //-------------------------

        public string? Decoration { get; set; }          //оформление стелы (как примечание)
        public string? NoteInstaller { get; set; }       //Примечания для установщиков
        public string? NoteProduction { get; set; }      //Примечания для производства




        public string? Note { get; set; }               //Примечания

        public Contract()
        {
            Customers = new List<Customer>();
            Stellas = new List<Stella>();
        }
        
    }
}
