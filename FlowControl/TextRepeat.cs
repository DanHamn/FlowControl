using System;

namespace FlowControl
{
    internal class TextRepeat
    {
        //Repeterar input string 10 gånger på samma rad med numrering
        internal static void Repeat10()
        {
            Console.WriteLine("Menyval 2: Upprepa 10 gånger");
            Console.WriteLine("Ange texten som ska upprepas");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: {input} ");
            }
            Console.WriteLine("");
        }
    }
}