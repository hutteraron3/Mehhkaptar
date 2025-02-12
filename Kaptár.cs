using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Kaptár
    {
        public int Kaptárméret { get; set; }

        public int PetékSzáma { get; set; }

        public int KaptárÉleterő { get; set; }

        public int MézMennyiség {  get; set; }

        public Kaptár(int kaptárMéret, int petékSzáma, int kaptárÉleterő, int mézMennyiség)
        {
            Kaptárméret = kaptárMéret;
        }

       

    }
}
