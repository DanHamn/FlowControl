using System;

namespace FlowControl
{
    internal class IntegerTest
    {

        public static int ReturnInt(string input) //Denna kod bekräftar om inputen är ett positivt heltal och ber användaren ange ett tal om input inte är det
        {
            bool success;
            int output;
            do
            {
                success = int.TryParse(input, out output); //Skickar false/true till success och heltalet till output
                if (success == false) //Om input inte är en int så kommer man hit
                {
                    Console.WriteLine("Måste ange ett positivt heltal");
                    input = Console.ReadLine();
                }
                else if (output < 0) //Om talet är mindre än 0 så kommer man hit
                {
                    Console.WriteLine("Måste ange ett positivt heltal");
                    input = Console.ReadLine();
                }
            } while (success);

            return output;
        }
    }
}