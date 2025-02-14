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

        public Királynő(int életerő)
        {
            Életerő = életerő;
        }

        public void Peterakás(Kaptár kaptár)
        {
            kaptár.PetékSzáma += 10;
            Életerő -= 20;

        }
    }
}
