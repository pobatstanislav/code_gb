using System;
using System.IO;
using System.Diagnostics;
using System.Linq;
//Написать консольное приложение Task Manager,
//которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
//Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
//В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.


namespace GB_CODE_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var procList = Process.GetProcesses();
            foreach (var proc in procList)
            {
                Console.WriteLine($"{proc.Id} {proc.ProcessName}");
            }
            Console.Write("Введите ID процесса = ");
            var name = Console.ReadLine();
            try
            {
                procList.First(p => p.ProcessName.ToLower() == name.ToLower()).Kill();
                Console.WriteLine($"{name} удален!");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Процес {name} не был найдет");
            }
        }
    }
}
