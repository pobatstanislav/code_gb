using System;

//4.	(*) Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом

namespace HelloWorld
{
    class less44
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Getfib(9)); // 9 - циклов метода 
        }


        static int Getfib(int number)
        {
            if (number == 0)
                return 0; // певое число
            if (number == 1) // второе число
                return 1;

            return Getfib(number - 1) + Getfib(number - 2); //
        }
    }
}
