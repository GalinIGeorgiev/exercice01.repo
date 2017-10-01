    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace teatreTicket
    {
        class Program
        {
            static void Main(string[] args)
            {
                string typeOfTheDay = Console.ReadLine().ToLower();
                int ageOfThePerson = int.Parse(Console.ReadLine());
                double price = 0;

                if ((typeOfTheDay == "weekday") && (ageOfThePerson >= 0 && ageOfThePerson <= 18 || ageOfThePerson > 64 && ageOfThePerson <= 122))
                {
                    price = 12;
                    Console.WriteLine(price + "$");
                }


                else if (typeOfTheDay == "weekday" && ageOfThePerson > 18 && ageOfThePerson <= 64)
                {
                    price = 18;
                    Console.WriteLine(price + "$");
                }


                else if ((typeOfTheDay == "weekend" )&& (ageOfThePerson >= 0 && ageOfThePerson <= 18 || ageOfThePerson > 64 && ageOfThePerson <= 122))
                {
                    price = 15;
                    Console.WriteLine(price + "$");
                }


                else if (typeOfTheDay == "weekend" && ageOfThePerson > 18 && ageOfThePerson <= 64)
                {
                    price = 20;
                    Console.WriteLine(price + "$");
                }

                else if (typeOfTheDay == "holiday" && ageOfThePerson >= 0 && ageOfThePerson <= 18)
                {
                    price = 5;
                    Console.WriteLine(price + "$");
                }
                else if (typeOfTheDay == "holiday" && ageOfThePerson > 18 && ageOfThePerson <= 64)
                {
                    price = 12;
                    Console.WriteLine(price + "$");
                }
                else if (typeOfTheDay == "holiday" && ageOfThePerson > 64 && ageOfThePerson <= 122)
                {
                    price = 10;
                    Console.WriteLine(price + "$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }

            }
        }
    }
