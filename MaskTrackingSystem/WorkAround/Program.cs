using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName="DURSUN ŞEREF";
person1.LastName = "KÖKTÜRK";
person1.DataOfBirthYear =1985;
person1.NationalityIdentity =12345678912;

Person person2 = new Person();
person2.FirstName = "Hakan";

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);