using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Virág
    {
        private int _virágporMennyiség;
        public int VirágporMennyiség { 
            get
            {
                return _virágporMennyiség;
            }


            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Nem mehetsz 0 alá.");

                }
                _virágporMennyiség = value;
            }

        
            }
        public string VirágFajta { get; set; }

        public Virág(int virágporMennyiség, string virágFajta)
        {
            VirágporMennyiség = virágporMennyiség;
            VirágFajta = virágFajta;
        }

    }
        
}
