using System;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class PttManager:ISupplierService
	{
		IApplicantService _applicantService;

		public PttManager(IApplicantService applicantService)
		{
			_applicantService = applicantService;
		}

		public void GiveMask(Person person)
		{
			if (_applicantService.CheckPerson(person))

			{
				Console.WriteLine(person.FirstName + " için Maske Verildi");
			}
			else
			{
				Console.WriteLine("Doğrulanamadı");
			}
		}
	}
}

