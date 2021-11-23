using System;
using System.IO;

namespace GB_CODE_54
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirN = @"C:\Program Files"; // "C:\\";  // путь для происка папок и файлов

            if (Directory.Exists(dirN))
            {
                Console.WriteLine("Папки");
                string[] dirs = Directory.GetDirectories(dirN); // новый строковый массив папок
                foreach (string str in dirs)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirN);      // новый строковый массив файлов
                foreach (string str in files)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
