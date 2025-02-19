﻿using System;
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

        public int Gyűjtés(Virág virág, int DolgozóEffektiveness)
        {
            virág.VirágporMennyiség -= 30;
            ÖsszegyűjtöttNektár += 10 + DolgozóEffektiveness;
            
            return ÖsszegyűjtöttNektár;
        }

        public void Mézkészítés(int KívántMennyiség, Méhsejt méhsejt)
        {
            ÖsszegyűjtöttNektár -= KívántMennyiség;
            méhsejt.Mézmennyiség += KívántMennyiség;

            

        }


    }
}
