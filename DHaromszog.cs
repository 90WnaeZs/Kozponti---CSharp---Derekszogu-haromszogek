using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haromszogek
{
    class DHaromszog
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;

        public double a
        {
            get { return aOldal; }
            set { if (value > 0) { aOldal = value; } else { throw new Exception("Az 'a' oldal nem lehet nulla vagy negatív!"); } }
        }

        public double b
        {
            get {return bOldal;}
            set { if (value >0) { bOldal = value; } else { throw new Exception("A 'b' oldal nem lehet nulla vagy negatív!"); } }
        }

        public double c
        {
            get { return cOldal; }
            set { if (value > 0) { cOldal = value; } else { throw new Exception("A 'c' oldal nem lehet nulla vagy negatív!"); } }
        }

        public int SorSzama
        {
            get;set;
        }

        private bool EllDerekszogu
        {
            get 
            { 
                if ((cOldal * cOldal)==(aOldal * aOldal)+(bOldal * bOldal))
                { return true; } 
                else 
                { return false; } 
            }
        }

        private bool EllMegszerkesztheto
        {
            get 
            { 
                if (aOldal + bOldal > cOldal)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool EllNovekvoSorrend
        {
            get
            {
                if(aOldal <= bOldal && bOldal <= cOldal)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public double Kerulet
        {
            get 
            {
                double kerulet = a + b + c;
                return kerulet; 
            }
        }

        public double Terulet
        {
            get { return ((this.aOldal * this.bOldal) / 2); }
        }

        public DHaromszog(string sor, int sorSzáma)
        {
            string[] oldalak = sor.Split(' ');

            this.a = Convert.ToDouble(oldalak[0]);
            this.b = Convert.ToDouble(oldalak[1]);
            this.c = Convert.ToDouble(oldalak[2]);

            if (!EllMegszerkesztheto)
            {
                throw new Exception("A háromszöget nem lehet megszerkeszteni!");
            }

            if (!EllNovekvoSorrend)
            {
                throw new Exception("Az adatok nincsenek növekvő rendben!");
            }

            if (EllDerekszogu && EllMegszerkesztheto && EllNovekvoSorrend)
            {
                this.a = Convert.ToDouble(oldalak[0]);
                this.b = Convert.ToDouble(oldalak[1]);
                this.c = Convert.ToDouble(oldalak[2]);
            }
            else
            {
                throw new Exception("A háromszög nem derékszögű!");
            }

            

            this.SorSzama = sorSzáma;
        }

    }
}
