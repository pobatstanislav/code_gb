using System;
using System.IO;

//1.	Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл


Console.WriteLine("Введите что нибудь:");
string str = Console.ReadLine();
//добавляем в файл info.txt
File.AppendAllText("info.txt", str);



