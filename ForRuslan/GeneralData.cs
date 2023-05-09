using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForRuslan
{
    internal class GeneralData
    {
        public int iterations = 0;
        public TimeSpan elapsedTime;

        public double func(double x)
        {
            double y = (Math.Pow(x, 2.0) * Math.Sin(x)) / 2.0;
            // double y = x * Math.Sin(x);
            return y;
        }

        public double dfunc(double x)
        {
            double dy = ((Math.Pow(x, 2.0) * Math.Cos(x)) / 2.0) + x * Math.Sin(x);
            return dy;
        }

        public double ddfunc(double x)
        {
            double ddy = Math.Sin(x) - ((Math.Pow(x, 2.0) * Math.Sin(x)) / 2.0) + 2 * x * Math.Cos(x);
            return ddy;
        }
    }
}
