using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Baskara
    {
        public static int[] CalculoRaizes(int a, int b, int c)
        {
            int[] result = new int[2];
            int delta = b * b - (4 * a * c);
            int x1 = (-b + Convert.ToInt32(Math.Sqrt(delta)))/2*a;
            int x2 = (-b - Convert.ToInt32(Math.Sqrt(delta))) / 2 * a;
            result[0] = x1 < x2 ? x1 : x2;
            result[1] = x1 > x2 ? x1 : x2;
            return result;
        }
    }
}
