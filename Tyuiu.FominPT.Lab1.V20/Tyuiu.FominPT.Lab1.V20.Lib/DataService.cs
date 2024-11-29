using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.FominPT.Lab1.V20.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y, double a)
        {
            double res = 8 * a
                + (2 * y + x - 3 * a) / (a * x - 8 * y)
                + (((2 + a) / (3 * y) * 3 + (a / y))
                / ((3 - a) / (x + Math.Pow(y, 3))));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
