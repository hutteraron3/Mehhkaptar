using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Kaptár
    {
        private int _petékSzáma;
        private int _kaptáréleterő;

        public int Kaptárméret { get; set; }

        public int PetékSzáma
        {
            get
            {
                return _petékSzáma;
            }

            set
            {
                if (MaxPetékSzáma < value)
                {
                    throw new ArgumentException("Nem lehet több petéd");

                }
                _petékSzáma = value;
            }
        }

        public int MaxPetékSzáma { get; set; }

        public int KaptárÉleterő { 
        get
        {
                return _kaptáréleterő;
        }
        set
        {
                if (KaptárÉleterő < 0)
                {
                    throw new ArgumentException("Túl kevés az életed, meghaltál");

                }
                _kaptáréleterő = value;
            }       
        }

        public int MézMennyiség { get; set; }

        public Kaptár(int kaptárMéret, int petékSzáma, int kaptárÉleterő, int mézMennyiség, int maxPetékSzáma)
        {
            Kaptárméret = kaptárMéret;
        }



    }
}
