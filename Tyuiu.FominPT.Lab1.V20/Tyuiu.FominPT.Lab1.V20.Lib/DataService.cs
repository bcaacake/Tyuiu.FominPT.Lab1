using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FominPT.Lab1.V20.Lib
{
    public class DataService
    {
        public double CalculateFirst(double x, double y, double a)
        {
            double res = 8 * a
                + (2 * y + x - 3 * a) / (a * x - 8 * y)
                + (((2 + a) / (3 * y) * 3 + (a / y))
                / ((3 - a) / (x + Math.Pow(y, 3))));
            res = Math.Round(res, 3);
            return res;
        }
        
        public double CalculateSecond(double x, double y, double a)
        {
            double res= 16 * a
                        - (4 * x - 2 * a + a) / (a + 2 * x + y)
                        + 3 * x
                        + (((a - 4) / y) / (5 * a / (x + 1)));

            res = Math.Round(res, 3);

            return res;
        }

    }
}
