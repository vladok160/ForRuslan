using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForRuslan
{
    internal class Methods : GeneralData
    {
        double a, b, E, c0;
        double answX, answY;
        public Methods(double a, double b, double E) //Конструктор для метода перебором
        {
            this.a = a;
            this.b = b;
            this.E = E;
            Perebor(a, b, E);
        }
        public Methods(double a, double b, double E, double c0) //Конструктор для второго метода
        {
            this.a = a;
            this.b = b;
            this.E = E;
            this.c0 = c0;
            CoatingMethodWithUnknownC(a, b, E, c0);
        }
        public string TimeOfDoing()
        {
            return Convert.ToString(elapsedTime.TotalMilliseconds);
        }
        public int GetIterations()
        {
            return iterations;
        }
        public double ForF()
        {
            return answY;
        }
        public double ForX()
        {
            return answX;
        }
        public void Perebor(double a, double b, double E)
        {
            double xmin, ymin, x, y;
            double L = 15.7;
            double N = (L * (b - a)) / (2 * E);
            double k = (b - a) / (2 * N);
            ymin = func(a + k);
            xmin = a + k;
            DateTime startTime = DateTime.Now;
            for (int i = 1; i <= N; i++)
            {
                x = a + (2 * i - 1) * k;
                y = func(x);
                if (y < ymin)
                {
                    xmin = x;
                    ymin = y;
                }
                iterations++;
            }
            answX = xmin;
            answY = func(xmin);
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
        }

        public double[] CoatingMethod(double a, double b, double e, double c)
        {
            double Fk = func(a), Rk, dopFk, x, resX = a, p = e / c;
            x = a + p;
            while (x <= b + p)
            {
                if ((b <= x) && (x <= b + p))
                    x = b;
                dopFk = func(x);
                if (dopFk < Fk)
                {
                    Fk = dopFk;
                    resX = x;
                }
                Rk = (e - Fk + dopFk) / c;
                x = x + p + Rk;
            }
            return new double[2] { resX, Fk };
        }
        public void CoatingMethodWithUnknownC(double a, double b, double e, double c0)
        {
            DateTime startTime = DateTime.Now;
            iterations = 2;
            double c = c0;
            double[] resArr1 = CoatingMethod(a, b, e, c), resArr2;
            c *= 2;
            resArr2 = CoatingMethod(a, b, e, c);
            while (Math.Abs(resArr2[1] - resArr1[1]) > e)
            {
                resArr1 = resArr2;
                c *= 2;
                resArr2 = CoatingMethod(a, b, e, c);
                iterations++;
            }
            DateTime endTime = DateTime.Now;
            elapsedTime = endTime - startTime;
            answX = resArr2[0];
            answY = resArr2[1];
            //return resArr2;
        }
    }
}
