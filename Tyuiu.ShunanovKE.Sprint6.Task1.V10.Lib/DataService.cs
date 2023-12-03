using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShunanovKE.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x < stopValue + 1; x++)
            {
                if ((3 * x + 0.5) != 0)
                {
                    y = Math.Sin(x) + (2.0 / (3 * x + 0.5)) - 2 * Math.Cos(x) * 2 * x;
                }
                else y = 0;
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}
