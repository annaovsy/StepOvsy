using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabGeneric
{
    class Statistic 
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>();

        public string ReadFile(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public void CalcWords(string str)
        {
            string[] slitWords = str.Split(' ', ',', '.');
            List<string> words = new List<string>();
            foreach (var word in slitWords)
            {
                if (!string.IsNullOrWhiteSpace(word))
                    words.Add(word);
            }

            foreach(var word in words)
            {
                if (dict.TryGetValue(word, out var value))
                {
                    dict[word] = value + 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
        }

        public void Show()
        {
            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }


    }
}
