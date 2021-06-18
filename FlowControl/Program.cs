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
                    BioPrice.BioMeny();


                    break;
                case "2":
                    Console.WriteLine("Menyval 2: Upprepa 10 gånger");
                    TextRepeat.Repeat10();

                    break;
                case "3":
                    Console.WriteLine("Menyval 3: Det tredje ordet");
                    ThirdWord.Find();

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
    }
}
