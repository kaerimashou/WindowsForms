using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA
{
        public interface IECalculator
        {
            void save_a(double a);

            void clear_a();

            double multi(double b);

            double sum(double b);

            double div(double b);

            double minus(double b);

            double sqrtx(double b);

            double power(double b);

            double sqrt();

            double square();

            double factorial();

        }
 }
