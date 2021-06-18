using System;

namespace FlowControl
{
    internal class BioPrice
    {
        internal static void BioMeny()
        {
            bool done = false;
            do
            {
                Menyval1();


                switch (Console.ReadLine())
                {
                    case "0":
                        done = true;
                        break;
                    case "1":
                        Console.WriteLine("Ange ålder");
                        BioPrice.DeterminPriceFromAge();

                        break;
                    case "2":
                        Console.WriteLine("Ange antal i sällskapet");
                        BioPrice.DeterminePriceFromGroup();

                        break;
                    default:
                        Console.WriteLine("Error: Felaktig input");
                        break;
                }

            } while (done != true);
        }
        internal static void DeterminPriceFromAge()
        {
            int age = int.Parse(Console.ReadLine());

            if (age < 5)
            {
                Console.WriteLine("Barn under 5 går gratis");
                Console.WriteLine(" ");
            }
            else if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr");
                Console.WriteLine(" ");
            }
            else if (age > 19 && age < 65)
            {
                Console.WriteLine("Standardpris: 120kr");
                Console.WriteLine(" ");
            }
            else if (age > 64 && age < 100)
            {
                Console.WriteLine("Pensionärspris: 90kr");
                Console.WriteLine(" ");
            }
            else if (age > 99)
            {
                Console.WriteLine("Pensionärer över 100 går gratis");
                Console.WriteLine(" ");
            }
        }

        internal static void DeterminePriceFromGroup()
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] ages = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Ange åldern för person nr. {i + 1}");
                ages[i] = int.Parse(Console.ReadLine());
            }
            int totalcost = new();
            foreach (int i in ages)
            {
                if (i < 20)
                {
                    totalcost += 80;
                }
                else if (i > 64)
                {
                    totalcost += 90;
                }
                else if (i > 19 && i < 65)
                {
                    totalcost += 120;
                }
            }
            Console.WriteLine($"Antal personer i sällskapet: {quantity}");
            Console.WriteLine($"Totalkostnad: {totalcost}");
            Console.WriteLine($" ");
        }


        private static void Menyval1()
        {
            Console.WriteLine("0. Gå tillbaka till huvudmenyn");
            Console.WriteLine("1. Prissättning efter ålder");
            Console.WriteLine("2. Prisberäkning för ett sällskap");
            Console.WriteLine(" ");
        }

    }
}