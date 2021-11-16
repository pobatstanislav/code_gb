using System;

//2.	Написать программу, принимающую на вход строку — набор чисел,
//разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
//Ввести данные с клавиатуры и вывести результат на экран.

namespace HelloWorld
{
    class less42
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа разделенне пробелом:");
            var str1 = Console.ReadLine();
            var summ = GetSumm(str1);
            Console.WriteLine(summ);


            static int GetSumm(string str) // метод сумма чисел из сроки с любыми разделителями
            {
                int res = 0;
                int num = 0;


                for (int i = 0; i < str.Length; i++)
                {
                    // новый код (решил проверять разделитель не только пробелы)
                    var ch = str[i];
                    //var chstr = ch.ToString();
                    switch (ch)
                    {
                        case '0':
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            int xr = int.Parse(ch.ToString());
                            num = num * 10 + xr;
                            break;
                        default:
                            res += num;
                            num = 0;
                            break;
                    }

                    // конец нового кода

                    /*
                                       var ch = str[i];
                                       if (ch != ' ')
                                       {
                                           int xr = int.Parse(ch.ToString());
                                           num = num * 10 + xr;

                                       }
                                       else
                                       {
                                           res += num;
                                           num = 0;
                                       }
                    */
                }

                if (num > 0)
                {
                    res += num;
                }


                return res;
            }
        }

    }
}
