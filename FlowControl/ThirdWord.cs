using System;

namespace FlowControl
{
    internal class ThirdWord
    {
        //Grundprogrammet för att hitta tredje ordet
        internal static void Find() 
        {
            Console.WriteLine("Menyval 3: Det tredje ordet");
            string[] words = UserPrompt();

            ReturnFind(words);
        }

        //Returerar resultatet av Find()
        private static void ReturnFind(string[] words) 
        {
            Console.WriteLine("Den angivna meningen var:");
            foreach (string word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Det tredje ordet är: {words[2]}");
            Console.WriteLine("");
        }


        //Hanterar input från användaren 
        private static string[] UserPrompt() 
        {
            do
            {
                int length = 3;//Denna int avgör hur många ord meningen ska vara. Måste vara lika med eller större än 
                Console.WriteLine($"Ange ett mening med minst {length} ord separerade med mellanslag");
                string input = new(Console.ReadLine());

                //Delar upp meningen i en array med ord och tar bort överflödiga mellanslag
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Ser till att input innehåller åtminstone tre ord med mellanslag mellan dem
                bool result = WordTest.Length(words, length);

                if (result == false)
                {
                    Console.WriteLine($"Error: Meningen var kortare än {length} ord");
                }
                else if (result == true)
                {
                    return words;
                }
                else
                {
                    Console.WriteLine("Error: Ett fel uppkom i ThirdWord.UserPrompt() eller i WordTest.Length()");
                    Environment.Exit(0);
                }
            } while (true);
        }
    }
}