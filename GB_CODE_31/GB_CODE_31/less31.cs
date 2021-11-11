using System;

//1. Написать программу, выводящую элементы двумерного массива по диагонали.
int[,] array = new int[3, 3]; //Новый массив 2х мерный массив
array[0, 0] = 111;
array[1, 0] = 211;
array[2, 0] = 311;
array[0, 1] = 121;
array[1, 1] = 221;
array[2, 1] = 331;
array[0, 2] = 122;
array[1, 2] = 222;
array[2, 2] = 322;

int num = 0; // отступ (количество пробелов) при выводе элемента массива на новой строке

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        string strArray = new string (' ', num); // отступаем пробелами num раз 
        Console.WriteLine($"{strArray}{array[i, j]}"); // пишем наш элемент массива в строку с num отступами в начале
        num++; // прибавляем пробел
    }

}

