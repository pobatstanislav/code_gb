using System;

//2. Написать программу «Телефонный справочник»: создать двумерный массив 5х2,
//хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.

var contact = new string[5, 2];
Console.WriteLine("1. Ввежите Имя пользователей (5 раз)");
for (int i = 0; i < contact.GetLength(0); i++)
    {
    contact[i, 0] = Console.ReadLine(); //имена контактов
    }
Console.WriteLine("2. Ввежите телефоны/emails пользователей (5 раз)");
for (int i = 0; i < contact.GetLength(0); i++)
{
    contact[i, 1] = Console.ReadLine(); //имена контактов
}
for (int i = 0; i < contact.GetLength(0); i++)
{
    Console.WriteLine($"{contact[i, 0],10} {contact[i, 1],-10}");
}
