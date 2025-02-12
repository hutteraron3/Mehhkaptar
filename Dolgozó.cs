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

        public int ÖsszegyűjtöttNektár {  get; set; }

        public Dolgozó(int összegyűjtöttNektár, int életerő) 
        {
            ÖsszegyűjtöttNektár = összegyűjtöttNektár;
            Életerő = Életerő;
        }

        public int Gyűjtés()
        {
            ÖsszegyűjtöttNektár += 10;
            return ÖsszegyűjtöttNektár;
        }
    }
}
