using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Polynome
    {
        private double[] poly = new double[10];

        public Polynome(double[] coeffs) 
        {
           int count  = 0;
            for (int i = this.poly.Length - 1; i >= 0; i--) 
            { 
                this.poly[i] = coeffs[count];
                count++;
            }
        }

        public void ScalarMul(double s) 
        {
            for (int i = 0; i < this.poly.Length; i++) 
            {
                this.poly[i] = this.poly[i] * s;
            }
        }

        public Polynome() 
        {
            for (int i = 0; i < this.poly.Length; i++) 
            {
                this.poly[i] = 0;
            }
        }

        public Polynome Add(Polynome poly1) 
        {
             Polynome sumPoly = new Polynome();
             for (int i = 0; i < this.poly.Length; i++) 
             {
                 sumPoly.poly[i] = poly1.poly[i] + this.poly[i];
             }
             return sumPoly;
        }

        public Polynome Sub(Polynome poly1)
        {
            Polynome difPoly = new Polynome();
            for (int i = 0; i < this.poly.Length; i++)
            {
                difPoly.poly[i] = this.poly[i] - poly1.poly[i];
            }
            return difPoly;
        }

        public double GetHighestExpo() {
            double high = 0;

            for (int i = 1; i < this.poly.Length; i++) 
            {
                if (this.poly[i] != 0) {
                    high = i;
                }
            }
            return high;
        }

        public override string ToString()
        {
            string str = "";
            bool flag = true;
            for (int i = this.poly.Length - 1; i >= 0; i--)
            {
                if (this.poly[i] > 0  && flag == true) 
                {
                    str += this.poly[i] + "x^" + i + " ";
                    flag = false;
                }

                else if (this.poly[i] > 0 )
                {
                    str += "+ " + this.poly[i] + "x^" + i + " ";
                    flag = false;
                }

                if (this.poly[i] < 0)
                {
                    str += this.poly[i] + "x^" + i + " ";
                    flag = false;
                }
                
            }
            return str;
        }
    }
}
