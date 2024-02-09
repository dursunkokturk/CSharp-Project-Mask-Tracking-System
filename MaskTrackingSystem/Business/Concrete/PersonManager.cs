using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Interface Dosyasini Implement Ediyoruz
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return new List<Person>();
        }

        // Maske Dagitiminda
        // Maska Verilecek Kisilerin
        // Bilgilerini Kontrol Ediyoruz
        // Kontrol Islemi Icin
        // Entities Katmani Altindaki Person.cs Dosyasi Icinde Bulunan
        // Person Class ini Parametre Olarak Veriyoruz
        public bool CheckPerson(Person person)
        {
            // Verilen Bilgilere Gore Mernis Sistemi Ile Kontrol Islemi Yapiyoruz
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalityIdentity,person.FirstName,person.LastName,person.DataOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}