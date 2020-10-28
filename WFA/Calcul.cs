using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
    class Calcul : IECalculator
    {
        private double a = 0;
        public void save_a(double a)
        {
            this.a = a;
        }

        public void clear_a()
        {
            a = 0;
        }

        public double multi(double b)
        {
            return a * b;
        }
        public double sum(double b)
        {
            return a + b;
        }
        public double minus(double b)
        {
            return a - b;
        }
        public double sqrtx(double b)
        {
            return Math.Pow(a, 1 / b);
        }
        public double power(double b)
        {
            return Math.Pow(a, b);
        }
        public double sqrt()
        {
            return Math.Sqrt(a);
        }
        public double square()
        {
            return Math.Pow(a, 2);
        }
        public double factorial()
        {
            double f = 1.0;
            for(double i = 1; i <= a; i=i+1.0)
            {
                f = f* (double)i;
            }
            return f;
        }
        public double div(double b)
        {
            return a / b;
        }
    }
}
