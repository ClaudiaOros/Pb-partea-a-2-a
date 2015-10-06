using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmField
{
    public static class FarmField
    {
        public const int width = 230;
        public const int totalSurface = 770000;

        public static double CalculateInitialSurface()
        {
            double delta;
            CalculateDelta(out delta);
            double initialLength;
            CalculateInitialLength(out initialLength,delta);

            double initialSurface = initialLength * initialLength;
            return initialSurface;
        }

        public static void CalculateDelta(out double delta)
        {
            delta = width * width + 4 * 1 * totalSurface;
        }

        public static void CalculateInitialLength(out double initialLength, double delta)
        {
            initialLength = (-230 + Math.Sqrt(delta)) / 2;
        }

       
    }
}
