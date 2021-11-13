using System;
//3. Написать программу, выводящую введённую пользователем строку в обратном порядке (olleH вместо Hello).

Console.WriteLine("Введите строку:");
var str = Console.ReadLine(); // запрос строки
char[] k = str.ToCharArray(); // преобразование в массив символов
var strRevers = ""; // пустая строка реверс пустая
for (int i = str.Length-1; i>=0; i--)
{
   // Console.Write(str[i]);
    strRevers = strRevers + k[i]; // запись символов строки в обратном порядке в строкуреверс
}

Console.WriteLine($"Ваша строка, на наоборот:  {strRevers}"); // вывод информации на панель
