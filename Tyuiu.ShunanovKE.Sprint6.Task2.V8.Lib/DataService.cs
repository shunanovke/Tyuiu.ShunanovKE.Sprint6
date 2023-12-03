using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShunanovKE.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0) y = 0;
                else y = Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x;
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}
