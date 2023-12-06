using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.ShunanovKE.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string words = ""; ;
            using (StreamReader reader = new StreamReader(path))
            {
                bool first = true;
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] linewords = line.Split(' ');
                    foreach(string word in linewords)
                    {
                        if (word.Contains('b'))
                        {
                            if (first == true)
                            {
                                words += word;
                                first = false;
                            }
                            else
                            {
                                words = words + " " + word;
                            }
                        }
                    }
                }
            }
            return words;
        }
    }
}
