using System;

/*
4.	Для полного закрепления понимания простых типов найдите любой чек, 
либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
только за место динамических, по вашему мнению, данных (это может быть дата, 
название магазина, сумма покупок) подставляйте переменные, 
которые были заранее заготовлены до вывода на консоль.
  */
string nameShop = "Семёрочка";                      // Название магазина
string addresShop = "Красная пл., Москва, 109012";  // Адресс магазина
DateTime dateAndTime = new DateTime(2021, 11, 05, 20, 00, 00); // Дата покупки
string productName1 = "Краная икра - 200 гр.";
string productName2 = "Тёмное пиво Guinness Draught, 0.44 л";
string productName3 = "Багет томатный Итальяно Хлеб Насущный";
double productPrice1 = 128.85;
double productPrice2 = 150.55;
double productPrice3 = 35.00;
int numberProduct1 = 2;
int numberProduct2 = 5;
int numberProduct3 = 1;
var costProduct1 = numberProduct1 * productPrice1;
var costProduct2 = numberProduct2 * productPrice2;
var costProduct3 = numberProduct3 * productPrice3;
var cost = costProduct1 + costProduct2 + costProduct3;
//
Console.WriteLine($"*************************************************************************************************************");
//

Console.WriteLine($"             Магазин: " +
    $"{nameShop,20}");
Console.WriteLine($"             Адресс: " +
    $"{addresShop,20}");
//
Console.WriteLine($"=============================================================================================================");
const string format2 = "{0,-60}{1,-20}{2,-15}{3}";
Console.WriteLine(format2, "Название продукта", "Цена продукта", "Количество", "Итого");
//
Console.WriteLine($"-------------------------------------------------------------------------------------------------------------");
//
Console.WriteLine($"{productName1,-60}{productPrice1,-20}{numberProduct1,-15}{costProduct1}"); // 
Console.WriteLine($"{productName2,-60}{productPrice2,-20}{numberProduct2,-15}{costProduct2}"); // 
Console.WriteLine($"{productName3,-60}{productPrice3,-20}{numberProduct3,-15}{costProduct3}"); // 
//
Console.WriteLine($"-------------------------------------------------------------------------------------------------------------");
Console.WriteLine($"             Итого:" +
    $"{cost,+84}");

Console.WriteLine($"*************************************************************************************************************");