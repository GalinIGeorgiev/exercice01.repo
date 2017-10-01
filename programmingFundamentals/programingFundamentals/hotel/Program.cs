            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

            namespace hotel
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        string month = Console.ReadLine().ToLower();
                        int nights = int.Parse(Console.ReadLine());

                        double pricePerStudio = 0;
                        double pricePerDouble = 0;
                        double pricePerSuite = 0;

                        switch (month)
                        {
                            case "may":
                            case "october": pricePerStudio = nights * 50; pricePerDouble = nights * 65; pricePerSuite = nights * 75; break;

                            case "june": 
                            case "september": pricePerStudio = nights * 60; pricePerDouble = nights * 72; pricePerSuite = nights * 82; break;

                            case "july":
                            case "august": 
                            case "december": pricePerStudio = nights * 68; pricePerDouble = nights * 77; pricePerSuite = nights * 89; break;
                    
                        }

                        if (nights > 7 && (month == "october" || month == "may"))
                        {
                            pricePerStudio *= 0.95;
                        }
                        else if (nights > 14 && (month == "june" || month == "september"))
                        {
                            pricePerDouble *= 0.90;
                        }
                        else if (nights > 14 && (month == "july" || month == "december" || month == "august"))
                        {
                            pricePerSuite *= 0.85;
                        }
                        if (nights > 7 && (month == "september"))
                        {
                            pricePerStudio =60*(nights-1);
                        }
                        if (nights > 7 && (month == "october"))
                        {
                            pricePerStudio = (50 * 0.95) * (nights - 1);
                        }

                        Console.WriteLine($"Studio: {pricePerStudio:f2} lv.");
                        Console.WriteLine($"Double: {pricePerDouble:f2} lv.");
                        Console.WriteLine($"Suite: {pricePerSuite:f2} lv.");
                    }
                }
            }
