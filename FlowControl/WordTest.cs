using System;

namespace FlowControl
{
    internal class WordTest
    {
        internal static bool Length(string[] words, int length)
        {
            if (words.Length < length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}