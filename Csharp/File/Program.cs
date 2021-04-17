using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void WriteFile(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                string str = "Test string";
                byte[] data = Encoding.Default.GetBytes(str); //возвращает массив байт str
                file.Write(data, 0, data.Length); 
            }
        }

        static string ReadFile(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                byte[] readBytes = new byte[file.Length];
                file.Read(readBytes, 0, readBytes.Length);

                return Encoding.Default.GetString(readBytes);
            }
        }

        static void SaveFile(string filename, string str)
        {
            using (FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(str);
                    
                    foreach(var item in str)
                    {
                        writer.Write($"{(char)(item + 1)}");
                    }
                }
            }
        }

        static string ReadSymbolFile(string filename)
        {
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader = new StreamReader(file))
                {
                    return reader.ReadToEnd(); 
                }
            }
        }

        static void WriteBinary(string filename)
        {
            using (var file = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                using (var writer = new BinaryWriter(file))
                {
                    double pi = 3.14;
                    int number = 150;
                    string str = "Text";

                    writer.Write(pi);
                    writer.Write(number);
                    writer.Write(str);
                }
            }
        }

        static void ReadBinary(string filename, out double pi, out int number, out string str)
        {
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(file))
                {
                    pi = reader.ReadDouble();
                    number = reader.ReadInt32();
                    str = reader.ReadString();
                }
            }
        }

        static void Main(string[] args)
        {
            WriteFile("testfile.txt");

            string str = ReadFile("testfile.txt");
            Console.WriteLine(str);

            SaveFile("testSymbolFile.txt", "ABCD");

            Console.WriteLine("**********************************");

            str = ReadSymbolFile("testSymbolFile.txt");
            Console.WriteLine(str);

            Console.WriteLine("**********************************");

            WriteBinary("fileBinary.bin");
            ReadBinary("fileBinary.bin", out var pi, out var number, out var strTest);
            Console.WriteLine($"{pi} {number} {strTest}");

            Directory.CreateDirectory(@"fileBinary\example"); // создает папки

        }
    }
}
