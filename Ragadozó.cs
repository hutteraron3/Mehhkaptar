using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Ragadozó
    {
        int Életerő { get; set; }

        int Sebzés { get; set; }

        int TámadóFajta { get; set; }

        int Támadás_effektivitása {  get; set; }
        public Ragadozó(int életerő, int sebzés, int támadóFajta, int támadás_effektivitása)
        {
            Életerő = életerő;
            Sebzés = sebzés;
            TámadóFajta = támadóFajta;
            Támadás_effektivitása = támadás_effektivitása;
        }

        public void Támadás(Kaptár kaptár)
        {
            
            Random rnd = new Random();
            int támadásEsélye = rnd.Next(100,100);
            if ( támadásEsélye > Támadás_effektivitása )
            {
                kaptár.KaptárÉleterő -= Sebzés;

            }
            if (támadásEsélye > Támadás_effektivitása * 2)
            {
                kaptár.KaptárÉleterő -= Sebzés * 2;

            }
        }

        

        

    }
}
