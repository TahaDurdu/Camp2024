﻿using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{

    
    public class PersonManager : IApplicantService
    {
   
        public void ApplyForMask(Person person)
        {
           
        }

        public bool CheckPerson(Person person)
        {
            
             Dogrulama dogrulama = new Dogrulama(TCKimlikNo :person.TcNo, Adi:person.FirstName,Soyadi:person.LastName,DogumYili:person.DateOfBirthYear);
             return dogrulama.KisiVarMi();  
        }

        public List<Person> GetList()
        {
            return null;
        }
    }
}

