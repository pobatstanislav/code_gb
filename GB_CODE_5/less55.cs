using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;


namespace GB_CODE_55_NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Начало
            string jsonIn = File.ReadAllText("task.json");                // чтение класса из json файла
            var myTodosFile = JsonSerializer.Deserialize<ToDo[]>(jsonIn); // создаем новый массив классов ToDo из строки jsonIn
            //
            int numToDo = myTodosFile.GetLength(0);         // размер массива из файла json
            string IsDoneStr = "[x]";                       // строка - изображегние выполненой задачи
                                                            // Вывод на экран список задач из файла по циклу
            for (int i = 0; i < numToDo; i++)
            {

                if (myTodosFile[i].IsDone == true) // если залача выполенена, то пиши напротив задачи [x]
                {
                    Console.WriteLine($"{i + 1} {myTodosFile[i].Title,-3} {IsDoneStr,12}");
                    // иначе вывести описание задачи
                }
                else Console.WriteLine($"{i + 1} {myTodosFile[i].Title,-3}");

            }

            // 
            Console.WriteLine("Ведите номер задачи, которую нужно завершить:");
            int taskIsDone = Convert.ToInt32(Console.ReadLine());
            myTodosFile[taskIsDone - 1].IsDone = true; // Установит статус задачи

            // создание массива больше
            var myTodos = new ToDo[numToDo + 1];            // массив на строку больше
            for (int i = 0; i < numToDo; i++)               // копируем данные из myTodosFile в myTodos
            {
                myTodos[i] = myTodosFile[i];
            }

            // Заполняем последнию строку массива
            Console.WriteLine("Введите описание новой задачи");
            string strTitle = Console.ReadLine(); // Новая задача, нужна проверка
            myTodos[numToDo] = new ToDo
            {
                Title = strTitle,
                IsDone = false //по умолчание задача не завершена
            };


            // Вывод на экран список задач из файла по циклу
            for (int i = 0; i < numToDo + 1; i++)
            {

                if (myTodos[i].IsDone == true) // если залача выполенена, то пиши напротив задачи [x]
                {
                    Console.WriteLine($"{i + 1} {myTodos[i].Title,-3} {IsDoneStr,12}");
                    // иначе вывести описание задачи
                }
                else Console.WriteLine($"{i + 1} {myTodos[i].Title,-3}");

            }




            // запись класса в json
            string jsonOut = JsonSerializer.Serialize(myTodos);
            // Console.WriteLine(json);
            File.WriteAllText("task.json", jsonOut);


        }

    }


    public class ToDo
    {

        public bool IsDone { get; set; }
        public string Title { get; set; }
    }





}
