using System;

namespace FlowControl
{
    internal class Text
    {
        internal static void Repeat10(string input)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}: {input} ");
            }
        }
    }
}