// See https://aka.ms/new-console-template for more information
using LambdaDemo.Models;
using LambdaDemo.Repositories;
using System.Runtime.Intrinsics.Arm;
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


//LINQ Query
string[] names = { "TamilSelvan", "Dananjay", "Harry","Tom" };

IEnumerable<string> filteredNames =
  Enumerable
  .Where(names, n => n.Length >= 4)
  .OrderBy(n => n.Length)
  .Select(n => n.ToUpper());

filteredNames.ToList().ForEach(Console.WriteLine);

//Select Query
List<int> randNumbers = new List<int>();
for (int i = 0; i < 5; i++)
    randNumbers.Add(new Random().Next(1, 1000));
IEnumerable<int> numberQuery = randNumbers.Select(n => n * 10);
numberQuery.ToList().ForEach(Console.WriteLine);

//subquery
List<string> users = new List<string>();
users.Add("Parameswari Bala");
users.Add("Angelina Thomas");
users.Add("Sharmila Kumar");
users.Add("Arun Singh");
users.Add("Jyoti Tyagi");
users.OrderBy(u => u.Split().Last()).ToList().ForEach(Console.WriteLine);


//progressive sub query
IEnumerable<string> derivedNames = names.OrderBy(n => n.Length);
derivedNames.Select(n => n.Length).ToList().ForEach(Console.WriteLine);

(from n in names
 where n.Length ==
 (from n1 in names orderby n1.Length select n1.Length).First()
 select n).ToList().ForEach(Console.WriteLine);