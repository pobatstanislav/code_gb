using System;
//5.  (*) Если пользователь указал месяц из зимнего периода,
// а средняя температура > 0, вывести сообщение «Дождливая зима».
Console.WriteLine("1. Введите значение минимальной температуры за сутки (градусы Цельсия):"); // Запрос min температуры
    var tempMin = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("2. Введите значение максимальной температуры за сутки (градусы Цельсия):"); // Запрос max температуры
    var tempMax = Convert.ToSingle(Console.ReadLine());
    //
    float tempMean = (tempMin + tempMax) / 2;
    Console.WriteLine("Введите порядковый номер (число от 1 до 12) текущего месяца:"); // Запрос числа месяца
var monthNumber = Convert.ToInt32(Console.ReadLine());
var monthStr = "";
switch (monthNumber)
{
    case 1:
        monthStr = "Январь";
        //Console.WriteLine(monthStr);
        break;
    case 2:
                monthStr = "Февраль";
        //Console.WriteLine(monthStr);
        break;
    case 3:
        monthStr = "Март";
        //Console.WriteLine(monthStr);
        break;
    case 4:
        monthStr = "Апрель";
        //Console.WriteLine(monthStr);
        break;
    case 5:
        monthStr = "Май";
        //Console.WriteLine(monthStr);
        break;
    case 6:
        monthStr = "Июнь";
        //Console.WriteLine(monthStr);
        break;
    case 7:
        monthStr = "Июль";
        //Console.WriteLine(monthStr);
        break;
    case 8:
        monthStr = "Август";
        //Console.WriteLine(monthStr);
        break;
    case 9:
        monthStr = "Сентярь";
        //Console.WriteLine(monthStr);
        break;
    case 10:
        monthStr = "Октябрь";
        // Console.WriteLine(monthStr);
        break;
    case 11:
        monthStr = "Ноябрь";
        //Console.WriteLine(monthStr);
        break;
    case 12:
        monthStr = "Декабрь";
        //Console.WriteLine(monthStr);
        break;
    default:
        Console.WriteLine("Ошибка, нужно ввести число от 1 до 12");
        break;
}
//
if ((tempMean>0) && (monthNumber==1 || monthNumber == 2 || monthNumber == 12)) // Условие
{
    Console.WriteLine($"Текущий месяц: {monthStr} {Environment.NewLine}Cреднесуточная температура равна = {tempMean}°C {Environment.NewLine}Дождливая зима");
}
else
{
    Console.WriteLine($"Всего доброго");
}



