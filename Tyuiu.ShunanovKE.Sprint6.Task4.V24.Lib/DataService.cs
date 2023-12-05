using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShunanovKE.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = (Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2 * x;
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}
