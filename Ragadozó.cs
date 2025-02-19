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

        string TámadóFajta { get; set; }

        int Támadás_effektivitása {  get; set; }
        public Ragadozó(int életerő, int sebzés, string támadóFajta, int támadás_effektivitása)
        {
            Életerő = életerő;
            Sebzés = sebzés;
            TámadóFajta = támadóFajta;
            Támadás_effektivitása = támadás_effektivitása;
        }

        public void Támadás(Kaptár kaptár, Királynő királynő)
        {
            
            Random rnd = new Random();
            int támadásEsélye = rnd.Next(0,101);
            if ( támadásEsélye  < Támadás_effektivitása )
            {
                kaptár.KaptárÉleterő -= Sebzés;
                királynő.Életerő -= Sebzés / 2;

            }
            if (támadásEsélye < Támadás_effektivitása / 2)
            {
                kaptár.KaptárÉleterő -= Sebzés;
                királynő.Életerő -= Sebzés / 2;

            }
            
            
        }

        

        

    }
}
