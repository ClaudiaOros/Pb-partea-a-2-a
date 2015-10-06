using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavage
{
    public static class Pavage
    {
        public static double CalculateCubicStones(double fieldLength, double fieldWidth, double stoneLength)
        {
            double formula = Math.Ceiling(fieldLength / stoneLength) * Math.Ceiling(fieldWidth / stoneLength);
            return formula;
        }
    }
}
