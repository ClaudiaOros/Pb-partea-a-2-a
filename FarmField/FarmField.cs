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

            Calculate2ndDegreeEquation(a, width, totalSurface, out x1, out x2);

            if (x1 > 0)
                initialSurface = x1 * x1;
            else initialSurface = x2 * x2;

            return initialSurface;
        }

        // aX^2 + bX + c = 0
        public static void Calculate2ndDegreeEquation(int a, int b, int c, out double x1, out double x2)
        {
            var delta = b * b - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a;
        }       
    }
}
