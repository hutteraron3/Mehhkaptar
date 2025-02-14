using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Virág
    {
        public int VirágporMennyiség { get; set; }
        public string VirágFajta { get; set; }

        public Virág(int virágporMennyiség, string virágFajta)
        {
            VirágporMennyiség = virágporMennyiség;
            VirágFajta = virágFajta;
        }

    }
        
}
