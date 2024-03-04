

using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

CourseManager courseManager = new(new EfCourseDal());
List<Course> courses2 = courseManager.GetAll();

foreach (var i in courses2)
{
    Console.WriteLine(i.Name);
}

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.FirstName = "Taha";
customer1.LastName = "Durdu";
customer1.CustomerNumber = 123456;
customer1.NationalIdentity = "12345678912";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.FirstName = "Kerem";
customer2.LastName = "Etc";
customer2.CustomerNumber = 789045;
customer2.NationalIdentity = "56347865932";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.CustomerNumber = 764536;
customer3.Name = "Kodlamaio";
customer3.TaxNumber = "1234567";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.CustomerNumber = 736498;
customer4.Name = "Abc";
customer4.TaxNumber = "64573829071";

BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}