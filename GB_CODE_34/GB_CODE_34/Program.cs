//*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

var array  = new int [10, 10];
array[0, 0] = 1;
array[0, 1] = 1;
array[0, 2] = 1;
array[0, 3] = 1;
array[2, 1] = 1;
array[2, 3] = 1;
array[3, 1] = 1;
array[3, 3] = 1;
array[4, 1] = 1;
array[4, 3] = 1;
array[6, 1] = 1;
array[6, 2] = 1;
array[6, 4] = 1;
array[6, 5] = 1;
array[6, 7] = 1;
array[6, 8] = 1;
array[8, 1] = 1;
array[8, 4] = 1;
array[8, 6] = 1;
array[8, 8] = 1;
string str = "";

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (array[i, j] == 1) // Если 1 
        { str = str + "X";    //то пиши X
        }
        else str = str + "O";
     }
    System.Console.WriteLine(str);
    str = ""; //обнуляем строку
}