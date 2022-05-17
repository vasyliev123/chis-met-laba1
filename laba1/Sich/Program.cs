using System;

namespace Sich
{
    
    class Program
    {
        static double f(double x)
        {
            return Math.Pow(Math.Cos(x), 2) + (2 / 35f) * Math.Cos(x) - (1 / 35f);
        }
        static double g(double x)
        {
            return Math.Pow(Math.Cos(x), 2) - (2 / 7f) * Math.Cos(x) + (1 / 49f);
        }
        static void Main(string[] args)
        {
            
            double a = 1.7, b = 1.6;
            double e1 = 1e-4, e2 = 1e-5, e3 = 1e-6;
            double x = 0;
            double t;
            
            do
            {
                t = x;
                x = a - ((a - b) / (g(a) - g(b))) * g(a);
                b = a;
                a = x;
              
            }
            while (Math.Abs(t - x) >= e3);
            Console.WriteLine(x);
            //f:
            //e1 1.772154364792425
            //e2 1.7721542482627064
            //e3 1.7721542482627064

            //g:
            //e1 1.4275951803975566
            //e2 1.4274975239933518
            //e3 1.4274966517274073
        }
    }
}
