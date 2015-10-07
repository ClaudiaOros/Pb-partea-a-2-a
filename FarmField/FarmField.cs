using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmField
{
    public static class FarmField
    {
        public static double CalculateInitialSurface(int a, int width, int totalSurface)
        {
            double x1 = 0;
            double x2 = 0;
            double initialSurface;

            Calculate2ndDegreeEquation(a, width, totalSurface, ref x1, ref x2);

            if (x1 > 0)
                initialSurface = x1 * x1;
            else initialSurface = x2 * x2;

            return initialSurface;
        }

        // aX^2 + bX + c = 0
        public static void Calculate2ndDegreeEquation(int a, int b, int c, ref double x1, ref double x2)
        {        
            var delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            }
                else if (delta < 0)
                {
                    throw new System.ArgumentException("No real roots");
                }
                else
                {
                    x1 = -b /( 2 * a);
                    x2 = x1; 
                }                
        }       
    }
}
