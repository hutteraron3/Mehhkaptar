using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Méh
{
    internal class Királynő
    {
        public int Életerő { get; set; }

        public int PetekelésIdő { get; set; }
        public Királynő(int életerő, int petekelésIdő)
        {
            Életerő = életerő;
            PetekelésIdő = petekelésIdő;
        }

        public void Peterakás(Kaptár kaptár)
        {
            kaptár.PetékSzáma += 10;
            Életerő -= 20;
            
            

        }
    }
}
