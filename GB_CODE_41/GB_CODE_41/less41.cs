using System;

/// 
/// 1.	Написать метод GetFullName(string firstName, string lastName, string patronymic), 
/// принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
/// Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
/// 

{
    int n = 4; //количество участников опроса
    var contact = new string[n]; // список конатктов
        for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Заполните анкету для учатсника № {i+1} из {n}");
        contact[i] = GetFullName();
        // Console.WriteLine(GetFullName());
    }
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"{contact [i]}");
    }
}
static string GetFullName()
{
    Console.WriteLine("Введи свою Фамилию:");
    string firstName = Console.ReadLine();
    Console.WriteLine("Введи свое Имя:");
    string lastName = Console.ReadLine();
    Console.WriteLine("Введи свое Имя:");
    string patronymic = Console.ReadLine();
    //string FIO = firstName + " " + lastName + " " + patronymic;
    //return FIO;
    return firstName + " " + lastName + " " + patronymic;
}

