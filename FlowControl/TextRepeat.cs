using System;

namespace FlowControl
{
    internal class TextRepeat
    {
        internal static void Repeat10()
        {
            Console.WriteLine("Ange texten som ska upprepas");
            string input = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: {input} ");
            }
        }
    }
}