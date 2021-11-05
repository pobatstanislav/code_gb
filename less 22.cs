using System;
//2.	Запросить у пользователя порядковый номер текущего месяца и вывести его название
Console.WriteLine("Введите порядковый номер (число от 1 до 12) текущего месяца:"); // Запрос числа месяца
var monthNumber = Convert.ToInt32(Console.ReadLine());
switch (monthNumber)
{
    case 1:
        Console.WriteLine("Январь");
        break;
    case 2:
        Console.WriteLine("Февраль");
        break;
    case 3:
        Console.WriteLine("Март");
        break;
    case 4:
        Console.WriteLine("Апрель");
        break;
    case 5:
        Console.WriteLine("Май");
        break;
    case 6:
        Console.WriteLine("Июнь");
        break;
    case 7:
        Console.WriteLine("Июль");
        break;
    case 8:
        Console.WriteLine("Август");
        break;
    case 9:
        Console.WriteLine("Сентярь");
        break;
    case 10:
        Console.WriteLine("Октябрь");
        break;
    case 11:
        Console.WriteLine("Ноябрь");
        break;
    case 12:
        Console.WriteLine("Декабрь");
        break;
    default:
        Console.WriteLine("Ошибка, нужно ввести число от 1 до 12");
        break;
}
/**
//string iString = "05";
var monthNumber = Convert.ToInt32(Console.ReadLine());
string strmonthNumber = monthNumber.ToString("00"); // 001
DateTime oDate = DateTime.ParseExact(strmonthNumber, "MM", null);
Console.WriteLine(oDate.ToString("m")); 
//Console.WriteLine(oDate.Month);
*/