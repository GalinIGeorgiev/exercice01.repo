using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            string typeOfService = Console.ReadLine();

            string typeOfHall = "";
            double pricePerPerson = 0;

            if (quantity <= 50)
            {
                typeOfHall = "Small Hall";

                switch (typeOfService)
                {
                    case "Normal":
                        pricePerPerson = ((2500 + 500) * 0.95) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Gold":
                        pricePerPerson = ((2500 + 750) * 0.90) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Platinum":
                        pricePerPerson = ((2500 + 1000) * 0.85) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                }
            }
            else if (quantity > 50 && quantity <= 100)
            {
                typeOfHall = "Terrace";

                switch (typeOfService)
                {
                    case "Normal":
                        pricePerPerson = ((5000 + 500) * 0.95) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Gold":
                        pricePerPerson = ((5000 + 750) * 0.90) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Platinum":
                        pricePerPerson = ((5000 + 1000) * 0.85) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                }
            }
            else if (quantity > 100 && quantity <= 120)
            {
                typeOfHall = "Great Hall";
                switch (typeOfService)
                {
                    case "Normal":
                        pricePerPerson = ((7500 + 500) * 0.95) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Gold":
                        pricePerPerson = ((7500 + 750) * 0.90) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                    case "Platinum":
                        pricePerPerson = ((7500 + 1000) * 0.85) / quantity; Console.WriteLine($"We can offer you the {typeOfHall}");
                        Console.WriteLine($"The price per person is {pricePerPerson:f2}$"); break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}

