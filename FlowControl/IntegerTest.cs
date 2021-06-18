using System;

namespace FlowControl
{
    internal class IntegerTest
    {

        public static int ReturnInt() //Denna kod bekräftar om inputen är ett positivt heltal och ber användaren ange ett tal om input inte är det
        {
            do
            {
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int output); //Skickar false/true till success och heltalet till output
                if (success == false) //Om input inte är en int så kommer man hit
                {
                    Console.WriteLine("Måste ange ett positivt heltal");
                }
                else if (output < 0) //Om talet är mindre än 0 så kommer man hit
                {
                    Console.WriteLine("Måste ange ett positivt heltal");
                }
                else //Om tallet är ett positivt heltal så kommer man hit
                {
                    return output;
                }
            } while (true);
        }
    }
}