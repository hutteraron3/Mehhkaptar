using System.Numerics;
using System.Text.RegularExpressions;

namespace Méh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idő;
            Kaptár VaszarKaptár = new Kaptár(100, 0, 100, 0, 100);
            Dolgozó Közmunkás = new Dolgozó(0, 100);
            Királynő VaszarQueen = new Királynő(100);
            Ragadozó Ragadozó1 = new Ragadozó(100,20,"darázs", 40);

            Virág ElsőVirág = new Virág(100, "Barackvirág");

            /* Közmunkás.Gyűjtés(ElsőVirág);
            Console.WriteLine($"{ElsőVirág.VirágporMennyiség} - {Közmunkás.ÖsszegyűjtöttNektár}");
            VaszarQueen.Peterakás(VaszarKaptár);
            Console.WriteLine(VaszarKaptár.MaxPetékSzáma);
            Ragadozó1.Támadás(VaszarKaptár);
            Console.WriteLine(VaszarKaptár.KaptárÉleterő);
            Console.ReadKey();
            */

            int KaptárSzimuláció = -1;
            while (KaptárSzimuláció != 0)
            {
                Console.WriteLine("Kaptár Szimuláció");
                Console.WriteLine("1 - Nektár gyűjtése");
                Console.WriteLine("2 - Mézkészítés");
                Console.WriteLine("3 - Peterakás");
                Console.WriteLine("Mit tegyünk?");
                // TODO: Random támadások
                // Különböző virágok
                // Kaptármérethez megfelelően magas számú anyagok
            KaptárSzimuláció = int.Parse(Console.ReadLine());
                if (KaptárSzimuláció == 0 || KaptárSzimuláció == 1 || KaptárSzimuláció ==  2 || KaptárSzimuláció == 3)
                switch (KaptárSzimuláció)
                {
                    case 0:
                        break;
                    case 1:
                        Közmunkás.Gyűjtés(ElsőVirág);
                        break;
                    case 2:
                            int KívántMennyiség = int.Parse(Console.ReadLine());
                            if (KívántMennyiség < )
                            {
                                Közmunkás.Mézkészítés(KívántMennyiség);
                            }
                            break;
                }
                else
                {
                    throw new Exception("Yuo need to put in correct numbers");
                }
            }
            
        }
    }
}
