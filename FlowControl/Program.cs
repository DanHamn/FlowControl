using System;

namespace FlowControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Övning 2- .NET C# - Flow Control");

            do
            {
                Console.WriteLine("Huvudmeny");
                Console.WriteLine("0. Avsluta programmet");
                Console.WriteLine("1. Ungdom eller pensionär");
                Console.WriteLine(" ");
                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Console.WriteLine("Menyval 1: Ungdom eller pensionär");
                        do
                        {
                            Console.WriteLine("Ange åldern på besökaren");
                            Console.WriteLine("0. för att gå tillbaka till huvudmenyn");
                            Console.WriteLine(" ");
                            int age = int.Parse(Console.ReadLine());
                            if (age == 0) //Fixa error: Man kan ha med sig 0 åriga bebisar
                            {
                                break;
                            }
                            else if (age < 20)
                            {
                                Console.WriteLine("Ungdomspris: 80kr");
                            }
                            else if (age > 64)
                            {
                                Console.WriteLine("Pensionärspris: 90kr");
                            }
                            else if (age > 19 && age < 65)
                            {
                                Console.WriteLine("Standardpris: 120kr");
                            }
                        } while (true);
                        break;
                    default:
                        Console.WriteLine("Error: Felaktig input");
                        break;
                }
            } while (true);
        }
    }
}
