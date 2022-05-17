using System;
namespace bisec
{
    class Program
    {
        static double f(double x)
        {
            return Math.Pow(Math.Cos(x), 2) + (2/35f) * Math.Cos(x) - (1/35f);
        }
        static double g(double x)
        {
            return Math.Pow(Math.Cos(x), 2) + (2 / 7) * Math.Cos(x) + (1 / 49);
        }

        static void Main(string[] args)
        {

            double a = 1.6, b = 2;
            double e1 = 1e-4, e2 = 1e-5, e3 = 1e-6;
            double x = 0;
          
               do
              {
                  x = ( (b) +  (a)) / 2;
                
                if (f(a)*f(x)>0)
                  {
                      a = x;
                  }
                  if (f(b) * f(x) > 0)
                   {
                      b = x;
                   }
            } 
              while (Math.Abs(b-a)>=2*e3);
            Console.WriteLine(x);
            //f:
            //e1 1.7720703125
            //e2 1.7721557617187498
            //e3 1.7721542358398437

        }
    }
}
