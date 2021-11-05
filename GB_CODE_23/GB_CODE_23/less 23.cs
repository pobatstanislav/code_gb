using System;
//3.	Определить, является ли введённое пользователем число чётным
Console.WriteLine("Проверка на четность: Введите число (разделитель точка)"); // Запрос числа
var strNumber = Console.ReadLine(); // Исходное чило
var strNumberCheck = strNumber; // Копия исходного числа, которое я буду проверять
//
// Мне было интересно, как проверить на четность
// не только целое число,а еще число с  плавающей точкой
// хотя может это не совсем коректно с точки зрения математики, строго проверка на четность применима только к целым числам.
// Поэтому перед проверкой на четность я удаляю точку в числе.
//
var charsToRemove = new string[] { ".", "," };
//
foreach (var c in charsToRemove)
{
    strNumberCheck = strNumber.Replace(c, string.Empty);
}
var Number = Convert.ToInt32(strNumberCheck); // Преобразуемка строку в число
//
if (Number % 2 == 0) // проверка на четность
{
    Console.WriteLine($"Ваше число {strNumber} четное");
}
else
{
    Console.WriteLine($"Ваше число {strNumber} нечетное");
}

