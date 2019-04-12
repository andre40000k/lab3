using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Zero
    {
        private double a; //c, d, e, f, g, h, k, l;
        private double b;
        public Zero()
        {

        }
        public Zero(double a, double b) /*double c, double d, double e, double f, double g, double h, double k, double l*/
        {
            this.a = a;
            B = b;
            //C = c;
            //D = d;
            //E = e;
            //F = f;
            //G = g;
            //H = h;
            //K = k;
            //L = l;
        }

        public override string ToString()
        {
            return "" + A;
        }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        //public double C { get => c; set => c = value >= 0 ? value : 0; }
        //public double D { get => d; set => d = value >= 0 ? value : 0; }
        //public double E { get => e; set => e = value >= 0 ? value : 0; }
        //public double F { get => f; set => f = value >= 0 ? value : 0; }
        //public double G { get => g; set => g = value >= 0 ? value : 0; }
        //public double H { get => h; set => h = value >= 0 ? value : 0; }
        //public double K { get => k; set => k = value >= 0 ? value : 0; }
        //public double L { get => l; set => l = value >= 0 ? value : 0; }

        //public static double operator +(Zero zero1, Zero zero2)
        //{
        //    double res1 = (zero1.a * zero2.b + zero2.a * zero1.b) / zero1.b * zero2.b;
        //    return res1;
        //}
        public static Zero operator +(Zero zero1, Zero zero2)
        {
                 return new Zero ((zero1.a* zero2.b + zero2.a * zero1.b), (zero1.b * zero2.b));
        }
        //public static Zero operator -(Zero zero4, Zero zero5)
        //{
        //    return new Zero((zero4.g * zero5.l - zero4.k * zero5.h) / zero4.h * zero5.l);
        //}

        public static Zero operator -(Zero zero1, Zero zero2)
        {
            return new Zero((zero1.a * zero2.b - zero2.a * zero1.b), (zero1.b * zero2.b));          
        }

        public static Zero operator /(Zero zero2,Zero zero1)
        {
            return new Zero (zero1.a * zero2.b, zero1.b * zero2.a);
            
        }
        public static Zero operator *(Zero zero1, Zero zero2)
        {
            return new Zero(zero1.a * zero2.a,  zero1.b * zero2.b);           
        }
    }
}
