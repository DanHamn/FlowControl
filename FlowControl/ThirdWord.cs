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
                Console.WriteLine("Ange ett mening med minst tre (3) ord separerade med mellanslag");
                string input = new(Console.ReadLine());

                //Delar upp meningen i en array med ord och tar bort överflödiga mellanslag
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Ser till att input innehåller åtminstone tre ord med mellanslag mellan dem
                if (words.Length < 3)
                {
                    Console.WriteLine("Error: Måste ange en mening med minst tre ord separerade med mellanslag");
                }
                else
                {
                    return words;
                }
            } while (true);
        }
    }
}