namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Millist kujundit soovid? (Ruut, Ring, Ristkülik, Kolmnurk)");
            string valik = Console.ReadLine().ToLower();

            switch (valik)
            {
                case "ruut":
                    RuuduProgramm();
                    break;
                case "ring":
                    RingiProgramm();
                    break;
                case "ristkülik":
                    RistkylikuProgramm();
                    break;
                case "kolmnurk":
                    KolmnurgaProgramm();
                    break;
                default:
                    Console.WriteLine("Vigane valik. Palun sisesta õige kujundi nimi.");
                    break;
            }
        }

        static void RuuduProgramm()
        {
            Console.WriteLine("Sisesta ruudu külje pikkus:");
            int kylg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ruut:");

            for (int i = 0; i < kylg; i++)
            {
                for (int j = 0; j < kylg; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int umbermoot = 4 * kylg;
            int pindala = kylg * kylg;

            Console.WriteLine($"Ruudu ümbermõõt on {umbermoot} ja pindala on {pindala} .");
        }

        static void RingiProgramm()
        {
            Console.WriteLine("Sisesta ringi raadius:");
            int raadius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ring:");

            for (int i = 0; i <= 2 * raadius; i++)
            {
                for (int j = 0; j <= 2 * raadius; j++)
                {
                    if (Math.Pow(i - raadius, 2) + Math.Pow(j - raadius, 2) <= Math.Pow(raadius, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            double umbermoot = 2 * Math.PI * raadius;
            double pindala = Math.PI * Math.Pow(raadius, 2);

            Console.WriteLine($"Ringi ümbermõõt on {umbermoot:F2} ja pindala on {pindala:F2} ühikut.");
        }

        static void RistkylikuProgramm()
        {
            Console.WriteLine("Sisesta ristküliku laius:");
            int laius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sisesta ristkyliku kõrgus:");
            int korgus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ristkülik:");

            for (int i = 0; i < korgus; i++)
            {
                for (int j = 0; j < laius; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int umbermoot = 2 * (laius + korgus);
            int pindala = laius * korgus;

            Console.WriteLine($"Ristküliku ümbermõõt on {umbermoot} ja pindala on {pindala} ühikut.");
        }

        static void KolmnurgaProgramm()
        {
            Console.WriteLine("Sisesta kolmnurga aluse pikkus:");
            int alus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kolmnurk:");

            for (int i = 1; i <= alus; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            double kolmnurgaKorgus = Math.Sqrt(3) / 2 * alus; // Kolmnurga kõrgus võrdkülgse kolmnurga puhul

            double umbermoot = 3 * alus;
            double pindala = 0.5 * alus * kolmnurgaKorgus;

            Console.WriteLine($"Kolmnurga ümbermõõt on {umbermoot} ja pindala on {pindala:F2} ühikut.");
        }
    }
}