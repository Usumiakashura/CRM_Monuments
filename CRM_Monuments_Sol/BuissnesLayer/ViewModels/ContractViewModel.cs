using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuissnesLayer.ViewModels
{
    public class ContractViewModel
    {
        public int Id { get; set; }                     //Id
        [Display(Name = "Дата заключения:")]
        public DateTime DateOfConclusion { get; set; }  //Дата заключения

        //--- Номер договора (составной) ---

        public string? NumYear { get; set; }             //часть, отвечающая за год
        public string? Place { get; set; }               //часть, отвечающая за офис (аббревиатура)
        public string? Number { get; set; }              //часть с номером (цифры, но может быть и БН)
        [Display(Name = "Рассрочка")]
        public bool InstallmentPayment { get; set; }    //рассрочка (добавляется буква "р" в конец)
        //----------------------------------

        public List<CustomerViewModel> Customers { get; set; }   //Все заказчики и их контакты

        //--- Место захоронения ---
        [Display(Name = "Самовывоз")]
        public bool Pickup { get; set; }                //Самовывоз (да/нет)
        [Display(Name = "Адрес захоронения:")]
        public string? BurialAddress { get; set; }       //место захоронения
        [Display(Name = "Ряд")]
        public int? Row { get; set; }                    //ряд
        [Display(Name = "Место")]
        public int? BurialPlace { get; set; }            //место
        [Display(Name = "Сектор")]
        public int? Sector { get; set; }                 //сектор
        [Display(Name = "Могила")]
        public int? Grave { get; set; }                  //могила
        [Display(Name = "Расстояние от МКАД")]
        public int? DistanceFromMKAD { get; set; }       //расстояние от МКАД
        [Display(Name = "Кол-во выездов")]
        public int? NumberOfTrips { get; set; }          //количество выездов

        //-------------------------

        [Display(Name = "Крайний срок:")]
        public DateTime DeadLine { get; set; }          //Срок выполнения заказа

        //-------------------------

        //public List<Deceased> Deceaseds { get; set; }   //Все усопшие
        public List<StellaViewModel> Stellas { get; set; }       //стеллы

        //-------------------------

        [Display(Name = "Оформление стелы (примечание):")]
        public string? Decoration { get; set; }          //оформление стелы (как примечание)
        [Display(Name = "Примечания (установщики):")]
        public string? NoteInstaller { get; set; }       //Примечания для установщиков
        [Display(Name = "Примечания (производство):")]
        public string? NoteProduction { get; set; }      //Примечания для производства




        [Display(Name = "Примечания:")]
        public string? Note { get; set; }               //Примечания

        public ContractViewModel()
        {
            Customers = new List<CustomerViewModel>();
            Stellas = new List<StellaViewModel>();
        }
    }
}
