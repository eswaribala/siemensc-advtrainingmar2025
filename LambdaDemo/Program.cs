// See https://aka.ms/new-console-template for more information
using LambdaDemo.Models;
using LambdaDemo.Repositories;
IRepository<Customer> customerRepository = new Repository<Customer>();

Func<Individual, Customer> addIndividual = (obj) =>
{
    return customerRepository.AddCustomer(obj);
};
Individual individual = new Individual()
{
    AccountNo = Faker.RandomNumber.Next(1000, 9999),
    Name = new FullName()
    {
        FirstName = Faker.Name.First(),
        LastName = Faker.Name.Last()
    },
    DOB = new DateTime(new Random().Next(1950, 2000), new Random().Next(1, 12), new Random().Next(1, 28)),
    Email = Faker.Internet.Email(),
    PhoneNumber = new Random().Next(900000000, 999999999),
    AddressList = new List<Address>()
     {
         new Address()
         {
             AddressId=Faker.RandomNumber.Next(1000,9999),

                City=Faker.Address.City(),
                DoorNo=Faker.RandomNumber.Next(1,100).ToString(),
                StreetName=Faker.Address.StreetName(),
         }
     }
};
Console.WriteLine(addIndividual.Invoke(individual));







