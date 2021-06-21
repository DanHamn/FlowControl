using System;

namespace FlowControl
{
    class Program
    {
        static void Main()
        {
            /* Övning 2 för Lexicons .Net utbildning 2021
             * Uppgiften var att skappa en huvudmeny som användaren sedan kan ta sig till tre andra menyer och där lösa tre olika problem
             * Uppgift 1 var att ge priset för en enskild person vid en specifik ålder samt vid ett mixat sällskap
             * Uppgift 2 var att upprepa en mening 10 gånger på samma rad
             * Uppgift 3 var att plocka ut det tredje ordet ur en mening och retunera det.
             */
            Console.WriteLine(" Övning 2 - .NET C# - Flow Control");

            do
            {
                ShowMainMeny();

                UserInput();

            } while (true);
        }
        private static void ShowMainMeny()
        {
            //Samling av instruktionerna för huvudmenyn
            Console.WriteLine("Huvudmeny");
            Console.WriteLine("0. Avsluta programmet");
            Console.WriteLine("1. Ungdom eller pensionär");
            Console.WriteLine("2. Upprepa 10 gånger");
            Console.WriteLine("3. Det tredje ordet");
            Console.WriteLine(" ");
        }

        private static void UserInput()
            //Samling av överliggande switchen som tar användar inputen och startar den specifika delen, samt stänger programmet
        {
            switch (Console.ReadLine())
            {
                case "0": //Stänger programmet
                    Environment.Exit(0);
                    break;

                case "1": //Startar Uppgift 1
                    BioPrice.BioMeny();
                    break;

                case "2": //Startar Uppgift 2
                    TextRepeat.Repeat10();
                    break;

                case "3": //Startar Uppgift 3
                    ThirdWord.Find();
                    break;

                default: //Felkod om man anger något annat än "0", "1", "2" eller "3"
                    Console.WriteLine("Error: Felaktig input");
                    break;
            }
        }


    }
}
