using Interface_and_Abstract_in_Real_Life_Example.Abstract;
using Interface_and_Abstract_in_Real_Life_Example.Concrete;
using Interface_and_Abstract_in_Real_Life_Example.Entities;
using System;
using System.Text.RegularExpressions;

namespace Interface_and_Abstract_in_Real_Life_Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*****Customer Registration System*****");
                Console.WriteLine("Type 1 to login to Starbucks.");
                Console.WriteLine("Type 2 to login to Nero.");
                Console.WriteLine("Type 3 to exit database.");

                Regex pattern = new Regex("^[a-zA-Z]+$");
                string choose = Console.ReadLine();

                if (pattern.IsMatch(choose))//On this line I blocked numeric input from keyboard.
                {
                    Console.WriteLine("Please enter a operation number and do not write non numeric characters.");
                }
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("*****Starbucks Customer Save*****");
                        BaseCustomerManager customerManagerStarbucks = new StarbucksCustomerManager(new CustomerCheckManager());
                        Console.Write("Please enter your customer name: ");
                        string name1 = Console.ReadLine().ToUpper();
                        Console.Write("Please enter your customer surname: ");
                        string surname1 = Console.ReadLine().ToUpper();
                        DateTime date = new DateTime(1988, 2, 9);
                        Console.Write("Please enter your Nationality Id: ");
                        string nationalId1 = Console.ReadLine();
                        customerManagerStarbucks.Save(new Customer { DateOfBirth = date, FirstName = name1, LastName = surname1, NationalityId = nationalId1 });
                        break;
                    case "2":
                        Console.WriteLine("*****Nero Customer Save*****");
                        BaseCustomerManager customerManagerNero = new NeroCustomerManager();
                        Console.Write("Please enter your customer name: ");
                        string name2 = Console.ReadLine().ToUpper();
                        Console.Write("Please enter your customer surname: ");
                        string surname2 = Console.ReadLine().ToUpper();
                        DateTime date2 = new DateTime(1988, 2, 9);
                        Console.Write("Please enter your Nationality Id: ");
                        string nationalId2 = Console.ReadLine();
                        customerManagerNero.Save(new Customer { DateOfBirth = date2, FirstName = name2, LastName = surname2, NationalityId = nationalId2 });
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please choose valid operation.");
                        break;
                }
            }
        }
    }
}
