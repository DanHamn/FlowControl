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

                    BioPrice.DeterminPriceFromAge();

                    break;
                case "2":

                    BioPrice.DeterminePriceFromGroup();

                    break;
                default:
                    Console.WriteLine("Error: Felaktig input");
                    break;
            }

            return done;
        }

        //Visar kostnaden för en pesron passerat på deras ålder i input
        internal static void DeterminPriceFromAge()
        {
            Console.WriteLine("Ange ålder");
            int age = IntegerTest.ReturnInt(Console.ReadLine());
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

        //Beräknar kostnaden på ett varierande stort sällskap
        internal static void DeterminePriceFromGroup()
        {
            Console.WriteLine("Ange antal i sällskapet");
            int quantity = IntegerTest.ReturnInt(Console.ReadLine());
            int[] ages = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Ange åldern för person nr. {i + 1}");
                ages[i] = IntegerTest.ReturnInt(Console.ReadLine());
            }

            int totalcost = new();
            foreach (int age in ages)
            {
                if (age < 5)
                {totalcost += PriceList(age); 
                }
                else if (age > 4 && age < 20)
                {totalcost += PriceList(age);
                }
                else if (age > 19 && age < 65)
                {totalcost += PriceList(age);
                }
                else if (age > 64 && age < 100)
                {totalcost += PriceList(age);
                }
                else if (age > 99)
                {totalcost += PriceList(age);
                }
            }

            Console.WriteLine($"Antal personer i sällskapet: {quantity}");
            Console.WriteLine($"Totalkostnad: {totalcost}kr");
            Console.WriteLine($" ");
        }

        //Samling av grund instruktionerna för Menyval 1
        private static void Menyval1()
        {
            Console.WriteLine("0. Gå tillbaka till huvudmenyn");
            Console.WriteLine("1. Prissättning efter ålder");
            Console.WriteLine("2. Prisberäkning för ett sällskap");
            Console.WriteLine(" ");
        }
        //Prislista för dem olika åldrarna.
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
                //Felkod om man råkar använda något input som är utanför prislistans if statements
                Console.WriteLine("Error: Hamnade utanför listan över priser i BioPrice.PriceList()");
                Console.WriteLine("Returerar 0");
                return 0;
            }
        }

    }
}