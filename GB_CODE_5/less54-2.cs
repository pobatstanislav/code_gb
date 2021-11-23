using System;
using System.IO;

{
    string dirN2 = @"C:\Program Files"; //  // путь для происка папок и файлов
    Dir(dirN2);
}

static void Dir(string dir) // 
{
    try
    {
        foreach (string fs in Directory.GetFiles(dir))
            Console.WriteLine(fs);
        foreach (string d in Directory.GetDirectories(dir))
        {
            Console.WriteLine(d);
            Dir(d);  // вызов сам себя
        }

    }
    catch (System.Exception ex1) // исключение
    {
        Console.WriteLine("Исключение" + ex1.Message);
    }
}