using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace GB_CODE_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string numStr = Console.ReadLine();                     // строка с числами
            string[] numStrAr = numStr.Split();                    // режим строки по пробелам
            byte[] numAr = new byte[100];
            for (int i = 0; i < numStrAr.Length; i++)
            {
                numAr[i] = Convert.ToByte(numStrAr[i]);
            };
            using (var bw = new BinaryWriter(File.OpenWrite("test.bin")))
            {
                bw.Write(numAr);
                bw.Flush();
            }

        }
    }
}
