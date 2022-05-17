using System;

namespace hord
{
    class Program
    {
        static double f(double x)
        {
            return Math.Pow(Math.Cos(x), 2) + (2 / 35f) * Math.Cos(x) - (1 / 35f);
        }
        static double g(double x)
        {
            return Math.Pow(Math.Cos(x), 2) + (2 / 7) * Math.Cos(x) + (1 / 49);
        }
        static void Main(string[] args)
        {
            double a = 1.2, b = 1.8;
            double e1 = 1e-4, e2 = 1e-5, e3 = 1e-6;
            double x = 0, t =0;

            do
            {
                x = a - g(a) * ((b - a) / (g(b) - g(a)));

                if (f(a)*f(x) > 0)
                {
                    t = a;
                    a = x;

                }
                if (f(b)*f(x) > 0)
                {
                    t = b;
                    b = x;
                   
                }
            }
            while (Math.Abs(t - x) >= 2*e3);
            Console.WriteLine(x);
            //f:
            //e1 1.772111236187099
            //e2 1.772148469150556
            //e3 1.7721534718491414
        }
    }
}
