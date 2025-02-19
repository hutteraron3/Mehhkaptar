using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Kaptár
    {
        
        private int _kaptáréleterő;

        public int Kaptárméret { get; set; }

        public int PetékSzáma {  get; set; }
        
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

        public int MaxÉleterő { get; set; }
        
        public int Idő { get; set; }


        public Kaptár(int kaptárMéret, int petékSzáma, int kaptárÉleterő,int maxÉleterő, int maxPetékSzáma, int idő)
        {
            Kaptárméret = kaptárMéret;
            PetékSzáma = petékSzáma;
            KaptárÉleterő = kaptárÉleterő;
            MaxÉleterő = maxÉleterő;
            
            Idő = idő;
        }

        public void Gyógyítás(Méhsejt méhsejt)
        {
            méhsejt.Mézmennyiség -= 20;
            KaptárÉleterő += 20;
        }

    }
}
