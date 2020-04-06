using System;
using CodeOrginizer.Entities;
using CodeOrginizer.Enums;
using CodeOrginizer.Helpers;


namespace CodeOrginizer
{

    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 22);
            john.Address = new Address();
            john.Address.Name = "Wall street";
            john.Address.Number = 24;
            john.SSN = PersonHelper.GenerateSSN();
            john.PrintPerson();

            Console.WriteLine("------------------------------------");

            Address bobsAdress = new Address()
            {
                Name = "Next To Wallstreet",
                Number = 1000
            };
            Address bobWorkingAdress = new Address()
            {
                Name = "Two streets after Wallstreet",
                Number = 101
            };
            Person bob = new Person()
            {
                Name = "Bob",
                Age = 55,
                Address = bobsAdress,
                SSN = PersonHelper.GenerateSSN(),
                Job = new Job()
                {
                    Address = bobWorkingAdress,
                    CompanyName = "G1",
                    Role = Role.Designer
                }
            };

            bob.DevelopersSeacret();

            Console.ReadLine();
        }
    }
}
