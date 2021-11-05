using System;
/*
 * 1. Запросить у пользователя минимальную и максимальную 
 *  температуру за сутки и вывести среднесуточную температуру
 */
Console.WriteLine("1. Введите значение минимальной температуры за сутки (градусы Цельсия):"); // Запрос min температуры
//var tempMin = float.Parse(Console.ReadLine());
var tempMin = Convert.ToSingle(Console.ReadLine());
//
Console.WriteLine("2. Введите значение максимальной температуры за сутки (градусы Цельсия):"); // Запрос max температуры
//var tempMax = float.Parse(Console.ReadLine());
var tempMax = Convert.ToSingle(Console.ReadLine());
//
float tempMean = (tempMin + tempMax) / 2; // Подсчет средней температуры
//
Console.WriteLine($"Cреднесуточная температура равна = {tempMean}, градусов Цельсия");