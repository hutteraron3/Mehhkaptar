using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Dolgozó
    {
        public int Életerő {  get; set; }

        public int ÖsszegyűjtöttVirágpor {  get; set; }

        public Dolgozó(int összegyűjtöttVirágpor, int életerő) 
        {
            ÖsszegyűjtöttVirágpor = összegyűjtöttVirágpor;
            Életerő = Életerő;
        }
    }
}
