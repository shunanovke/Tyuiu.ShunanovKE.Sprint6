using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ShunanovKE.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public int len = 20;
        public double[] LoadFromDataFile(string path)
        {
            double[] res = new double[len];
            int cnt = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res[cnt] = Math.Round(Convert.ToDouble(line),3);
                    cnt++;
                }
            }
            res = res.Where(val => val > 5).ToArray();
            return res;
        }
    }
}
