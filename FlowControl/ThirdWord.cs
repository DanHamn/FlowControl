using System;

namespace FlowControl
{
    internal class ThirdWord
    {

        internal static void Find()
        {
            Console.WriteLine("Menyval 3: Det tredje ordet");
            string[] words = UserPrompt();


            Console.WriteLine("Den angivna meningen var:");
            foreach (string word in words)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Det tredje ordet är: {words[2]}");
            Console.WriteLine("");

        }

        private static string[] UserPrompt()
        {

            do
            {
                Console.WriteLine("Ange ett mening med minst tre (3) ord separerade med mellanslag");
                string input = new(Console.ReadLine());
                string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
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