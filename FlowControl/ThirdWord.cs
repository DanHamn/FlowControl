using System;

namespace FlowControl
{
    internal class ThirdWord
    {
        internal static void Find()
        {
            Console.WriteLine("Ange ett mening med minst tre (3) ord");
            string input = new(Console.ReadLine());
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words[2]);

            //foreach (string word in words)
            //{
            //    Console.WriteLine($"<{word}>");
            //}
        }
    }
}