using System;

namespace FlowControl
{
    internal class BioPrice
    {
        internal static void BioMeny()
        {
            Console.WriteLine("Menyval 1: Ungdom eller pensionär");
            bool done = false;
            do
            {
                Menyval1();

                done = Input(done);

            } while (done != true);
        }

        private static bool Input(bool done)
        {
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

            return done;
        }

        internal static void DeterminPriceFromAge()
        {
            int age = IntegerTest.ReturnInt();
            int price = PriceList(age);

            if (age < 5)
            {
                Console.WriteLine("Barn under 5 går gratis");
                Console.WriteLine(" ");
            }
            else if (age > 4 && age < 20)
            {
                Console.WriteLine($"Ungdomspris: {price}kr");
                Console.WriteLine(" ");
            }
            else if (age > 19 && age < 65)
            {
                Console.WriteLine($"Standardpris: {price}kr");
                Console.WriteLine(" ");
            }
            else if (age > 64 && age < 100)
            {
                Console.WriteLine($"Pensionärspris: {price}kr");
                Console.WriteLine(" ");
            }
            else if (age > 99)
            {
                Console.WriteLine("Pensionärer över 100 går gratis");
                Console.WriteLine(" ");
            }
        }

        private static int PriceList(int age)
        {
            if (age < 5)
            {
                return 0;
            }
            else if (age > 4 && age < 20)
            {
                return 80;
            }
            else if (age > 19 && age < 65)
            {
                return 120;
            }
            else if (age > 64 && age < 100)
            {
                return 90;
            }
            else if (age > 99)
            {
                return 0;
            }
            else
            {
                Console.WriteLine("Error: Hamnade utanför listan över priser i BioPrice.PriceList()");
                Console.WriteLine("Returerar åldern istället ");
                return age;

            }
        }

        internal static void DeterminePriceFromGroup()
        {
            int quantity = IntegerTest.ReturnInt();
            int[] ages = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Ange åldern för person nr. {i + 1}");
                ages[i] = IntegerTest.ReturnInt();
            }
            int totalcost = new();
            foreach (int age in ages)
            {
                if (age < 5)
                {
                    totalcost += 0;
                }
                else if (age > 4 && age < 20)
                {
                    totalcost += 80;
                }
                else if (age > 19 && age < 65)
                {
                    totalcost += 120;
                }
                else if (age > 64 && age < 100)
                {
                    totalcost += 90;
                }
                else if (age > 99)
                {
                    totalcost += 0;
                }
            }
            Console.WriteLine($"Antal personer i sällskapet: {quantity}");
            Console.WriteLine($"Totalkostnad: {totalcost}kr");
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