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
                        Menyval1();

                        switch (Console.ReadLine())
                        {
                            case "0":
                                done = true;
                                break;
                            case "1":
                                Console.WriteLine("Ange ålder");
                                BioPrice.DeterminPriceFromAge();

                                break;
                            case "2":
                                Console.WriteLine("Ange antal i sällskapet");
                                BioPrice.DeterminePriceFromGroup();

                                break;
                            default:
                                Console.WriteLine("Error: Felaktig input");
                                break;
                        }

                    } while (done != true);
                    break;
                case "2":
                    Console.WriteLine("Ange texten som ska upprepas");
                    TextRepeat.Repeat10(Console.ReadLine());
                    
                    break;
                case "3":

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
            Console.WriteLine("2. Upprepa 10 gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine(" ");
        }
        private static void Menyval1()
        {
            Console.WriteLine("0. Gå tillbaka till huvudmenyn");
            Console.WriteLine("1. Prissättning efter ålder");
            Console.WriteLine("2. Prisberäkning för ett sällskap");
            Console.WriteLine(" ");
        }
    }
}
