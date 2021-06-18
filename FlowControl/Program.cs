using System;

namespace FlowControl
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Övning 2 - .NET C# - Flow Control");

            do
            {
                ShowMainMeny();

                UserInput();

            } while (true);
        }

        private static void UserInput()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("Menyval 1: Ungdom eller pensionär");

                    bool done = false;
                    do
                    {
                        Console.WriteLine("0. Gå tillbaka till huvudmenyn");
                        Console.WriteLine("1. Prissättning efter ålder");
                        Console.WriteLine("2. Prisberäkning för ett sällskap");
                        Console.WriteLine(" ");

                        switch (Console.ReadLine())
                        {
                            case "0":
                                done = true;
                                break;
                            case "1":
                                Console.WriteLine("Ange ålder");
                                int age = int.Parse(Console.ReadLine());

                                if (age < 20)
                                {
                                    Console.WriteLine("Ungdomspris: 80kr");
                                    Console.WriteLine(" ");
                                }
                                else if (age > 64)
                                {
                                    Console.WriteLine("Pensionärspris: 90kr");
                                    Console.WriteLine(" ");
                                }
                                else if (age > 19 && age < 65)
                                {
                                    Console.WriteLine("Standardpris: 120kr");
                                    Console.WriteLine(" ");
                                }

                                break;
                            case "2":
                                Console.WriteLine("Ange antal i sällskapet");
                                int quantity = int.Parse(Console.ReadLine());
                                int[] ages = new int[quantity];
                                for (int i = 0; i < quantity; i++)
                                {
                                    Console.WriteLine($"Ange åldern för person nr. {i + 1}");
                                    ages[i] = int.Parse(Console.ReadLine());
                                }
                                int totalcost = new();
                                foreach (int i in ages)
                                {
                                    if (i < 20)
                                    {
                                        totalcost += 80;
                                    }
                                    else if (i > 64)
                                    {
                                        totalcost += 90;
                                    }
                                    else if (i > 19 && i < 65)
                                    {
                                        totalcost += 120;
                                    }
                                }
                                Console.WriteLine($"Antal personer i sällskapet: {quantity}");
                                Console.WriteLine($"Totalkostnad: {totalcost}");
                                Console.WriteLine($" ");
                                break;
                            default:
                                Console.WriteLine("Error: Felaktig input");
                                break;
                        }




                    } while (done != true);
                    break;
                default:
                    Console.WriteLine("Error: Felaktig input");
                    break;
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine(" ");
        }
    }
}
