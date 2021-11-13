using System;
//3.Написать метод 1 по определению времени года. На вход подаётся число – порядковый номер месяца.
//На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
//Написать метод 2, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
//Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число,
//вывести в консоль текст «Ошибка: введите число от 1 до 12».

namespace HelloWorld
{
    class less43
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца, от 1 до 12:");
            var srtmonthNumber = Console.ReadLine();
            var srtmonthNumberInt = Convert.ToInt32(srtmonthNumber);
            if (srtmonthNumberInt < 1 || srtmonthNumberInt > 12)
            {
                Console.WriteLine("Ошибка, нужно ввести число от 1 до 12");
            }
             else
            { 
            var season = GetSezon(srtmonthNumberInt);
            var seasonName = GetSeasonsYearName(season);
            Console.WriteLine(seasonName);
            }
        }

        // Метод номер 1
        static SeasonsYear GetSezon (int monthNumber) // Метод номер месяца - время года из перечисления
        {
            switch (monthNumber)
            {
                case 12:
                case < 3:
                    return SeasonsYear.Winter;
                case < 6:
                    return SeasonsYear.Spring;
                case < 9:
                    return SeasonsYear.Summer;
                case < 12:
                    return SeasonsYear.Autumn;
                default:
                    return SeasonsYear.Winter;
                    //      Console.WriteLine("Ошибка, нужно ввести число от 1 до 12");
            }
        }
        //
        //
        //
        //
        enum SeasonsYear // Переисление времен года
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }
        // Метод номер 2
        static string GetSeasonsYearName (SeasonsYear season_m)
        {
            switch (season_m)
            {
                case SeasonsYear.Winter:
                    return "Зима";
                case SeasonsYear.Spring:
                    return "Весна";
                case SeasonsYear.Summer:
                    return "Лето";
                case SeasonsYear.Autumn:
                    return "Осень";
                default:
                    return "Зима";
                    //      Console.WriteLine("Ошибка, нужно ввести число от 1 до 12");
            }
        }
               


    }
}
