using System;

namespace FlowControl
{
    internal class IntegerTest
    {

        public static int ReturnInt()
        {
            do
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int output);
                if (success == false)
                {
                    Console.WriteLine("Måste ange ett heltal");
                }
                else
                {
                    return output;
                }
            } while (true);
        }
    }
}