using System.Numerics;
using System.Text.RegularExpressions;

namespace Méh
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Kaptár VaszarKaptár = new Kaptár(100, 0, 100, 100, 0);
            Méhsejt vaszarosméhsejt = new Méhsejt(100, 0);
            Dolgozó Közmunkás = new Dolgozó(0, 100);
            Királynő VaszarQueen = new Királynő(100, 0);
           

            Virág ElsőVirág = new Virág(100, "Barackvirág");
            Ragadozó Darázs = new Ragadozó(100, 30, "darázs", 60);
            /* Közmunkás.Gyűjtés(ElsőVirág);
            Console.WriteLine($"{ElsőVirág.VirágporMennyiség} - {Közmunkás.ÖsszegyűjtöttNektár}");
            VaszarQueen.Peterakás(VaszarKaptár);
            Console.WriteLine(VaszarKaptár.MaxPetékSzáma);
            Ragadozó1.Támadás(VaszarKaptár);
            Console.WriteLine(VaszarKaptár.KaptárÉleterő);
            Console.ReadKey();
            */

            int KaptárSzimuláció = -1;
            bool vihar = false;
            int viharszámláló = 0;

            while (KaptárSzimuláció != 0)
            {
                if (vihar == true)
                {
                    viharszámláló += 1;
                    if (viharszámláló == 3)
                    {
                        Console.WriteLine("A vihar elállt.");
                        vihar = false;
                        viharszámláló = 0;
                    }
                }
                
                VaszarKaptár.Idő++;
                VaszarQueen.PetekelésIdő++;
                Console.WriteLine("Kaptár Szimuláció");
                Console.WriteLine("1 - Nektár gyűjtése");
                Console.WriteLine("2 - Mézkészítés");
                Console.WriteLine("3 - Peterakás");
                Console.WriteLine("4 - Anyagok kiírása");
                Console.WriteLine("Mit tegyünk?");

                // TODO: Random támadások
                // Különböző virágok
                // Kaptármérethez megfelelően magas számú anyagok
                // dolgozók kikelnek 
            KaptárSzimuláció = int.Parse(Console.ReadLine());
                if (KaptárSzimuláció == 0 || KaptárSzimuláció == 1 || KaptárSzimuláció ==  2 || KaptárSzimuláció == 3 || KaptárSzimuláció == 4)
                switch (KaptárSzimuláció)
                {
                    case 0:
                        break;
                    case 1:
                            if (vihar == true)
                            {
                                Console.WriteLine("Nem gyűjthetsz Nektárt, várj míg eláll a vihar.");
                            }
                            else
                            {
                                Közmunkás.Gyűjtés(ElsőVirág);

                            }
                        break;
                    case 2:
                            Console.WriteLine("Mennyi mézet szeretnénk? ");

                            int KívántMennyiség = int.Parse(Console.ReadLine());
                            if (KívántMennyiség <= Közmunkás.ÖsszegyűjtöttNektár)
                            { 
                                Közmunkás.Mézkészítés(KívántMennyiség, vaszarosméhsejt);
                            }
                            else
                            {
                                Console.WriteLine("Nincs elég nektárod.");
                            }

                            break;
                    case 4:
                            Console.WriteLine("Összes anyagod: ");
                            Console.WriteLine($"\t Mézmennyiség: {vaszarosméhsejt.Mézmennyiség}");
                            Console.WriteLine($"\t Nektármennyiség: {Közmunkás.ÖsszegyűjtöttNektár}");
                            Console.WriteLine($"\t Peték száma: {VaszarKaptár.PetékSzáma}");



                            break;
                }
                else
                {
                    throw new Exception("You need to put in correct numbers");
                }
                Random rnd = new Random();
                int RandomEvent = rnd.Next(1, 5); 
                switch (RandomEvent)
                {
                    case 1:
                        {
                            
                            vihar = true;
                            Console.WriteLine("Vihar közeleg.");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Ellenség közeleg! ");
                            Darázs.Támadás(VaszarKaptár);
                            if (VaszarKaptár.KaptárÉleterő <= 0)
                            {
                                Console.WriteLine("Meghaltál!");
                                Console.ReadKey();
                                System.Environment.Exit(0);
                            }
                            Console.WriteLine($"Támadás utáni életerő: {VaszarKaptár.KaptárÉleterő}");
                            
                               break;

                        }
                }
            }
            
        }
    }
}
