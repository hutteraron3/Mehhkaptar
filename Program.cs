namespace Méh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idő;
            Kaptár VaszarKaptár = new Kaptár(100, 10, 50, 15, 100);
            Dolgozó Közmunkás = new Dolgozó(0, 100);
            Királynő VaszarQueen = new Királynő(100);

            Virág ElsőVirág = new Virág(100, "Barackvirág");

            Közmunkás.Gyűjtés(ElsőVirág);
            Console.WriteLine($"{ElsőVirág.VirágporMennyiség} - {Közmunkás.ÖsszegyűjtöttNektár}");
            VaszarQueen.Peterakás(VaszarKaptár);
            System.Environment.Exit(1);

        }
    }
}
