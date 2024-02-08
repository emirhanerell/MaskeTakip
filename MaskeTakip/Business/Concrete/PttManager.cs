using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantSevice _appliantSevice; // new ile PersonManager'dan nesne üretmek yerine bunu kullanıyoruz. // Interface'in referanslarını alır
        
        public PttManager(IApplicantSevice appliantSevice) // Bu yapı ile hem yabancılar hem türkler için maske dağıtımı gerçekleşebiliyor. Bu gücü interface'ten alıyoruz.
        {
            _appliantSevice = appliantSevice;   // Ve biz bu sınıftan bir nesne üreteceğimiz zaman bizden ForeignerManager'dan mı yoksa PersonManager'dan mı diye soracak.
        }
        public void GiveMask(Person person)
        {
            if(_appliantSevice.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + person.LastName + " için maske verildi " );
            }
            else
            {
                Console.WriteLine(person.FirstName + person.LastName + " için maske verilemedi");
            }
        }
    }
}
