using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        // Manager Class i Icindeki Yapilacak Islemde
        // Manager Class ina Bagimlilik Olmasini Engellemek Icin
        // Interface Dosyasini Dependency Injection Yontemi Ile Ekliyoruz
        IApplicantService _applicantService;

        // Constructor Icinde Interface Dosyasini Parametre Olarak Veriyoruz
        // Constructor Calistirildiginda Calisir
        public PttManager(IApplicantService applicantService)
        {
            // Constructor Icinde Dependency Injection Yontemi Ile Gelen Data yi Ve
            // 
            _applicantService = applicantService;
        }
        public void GiveMask(Entities.Concrete.Person person)
        {
            // Program.cs Dosyasinda Girilen Bilgileri Kontrol Etmek Icin
            // Dependency Injection Uzerinden Gelen Data Uzerinden
            // CheckPerson Fonksiyonu Icinde Person Parametresi Ile
            // Maskenin Kime Verildigini Yazdiriyoruz
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için Maske Verildi");
            }
            else
            {
                // Girilen Bilgilerde Hata Varsa Kullaniciya Verilecek Mesaj
                Console.WriteLine(person.FirstName + " için Maske Verildi");
            }
        }
    }
}