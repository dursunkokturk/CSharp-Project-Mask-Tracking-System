using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        // Maske Dagitiminda
        // Maska Verilecek Kisilerin
        // Bilgilerini Kontrol Ediyoruz
        // Kontrol Islemi Icin
        // Entities Katmani Altindaki Person.cs Dosyasi Icinde Bulunan
        // Person Class ini Parametre Olarak Veriyoruz
        bool CheckPerson(Person person);
    }
}