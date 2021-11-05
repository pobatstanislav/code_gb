using System;

/*
  6.  (*) Для полного закрепления битовых масок, попытайтесь создать универсальную 
структуру расписания недели, к примеру, чтобы описать работу какого либо офиса. 
Явный пример - офис номер 1 работает со вторника до пятницы, 
офис номер 2 работает с понедельника до воскресенья и выведите его на экран консоли.
*/
//
int officeShedule1 = 0b0000001; // признак работы офиса в понедельник 1
int officeShedule2 = 0b0000010; // признак работы офиса в вторник     2
int officeShedule3 = 0b0000100; // признак работы офиса в среду       4
int officeShedule4 = 0b0001000; // признак работы офиса в четверг     8
int officeShedule5 = 0b0010000; // признак работы офиса в пятницу     16
int officeShedule6 = 0b0100000; // признак работы офиса в субботу     32
int officeShedule7 = 0b1000000; // признак работы офиса в восресенье  64
//
// конфигурация расписания работы офиса 1 
int office1 = officeShedule2 | officeShedule3| officeShedule4| officeShedule5;
// конфигурация расписания работы офиса 2 
int office2 = officeShedule1 | officeShedule2 | officeShedule3 | officeShedule4 | officeShedule5 | officeShedule6 | officeShedule7;
//
int maskShedule1 = 0b0011101; // маска 1 (вторник - пяница)
int maskShedule2 = 0b1111111; // маска 2 (понедельник - воскресенье)
//
int officeMaskCheck1 = maskShedule1 & office1; // Проверка распиания работы офиса 1 (сравнение расписания и маски)
int officeMaskCheck2 = maskShedule2 & office2; // Проверка распиания работы офиса 2 (сравнение расписания и маски)
//
// Если расписание работы офиса полностью совпали с маской (True - совпало, иначе False)
Console.WriteLine(officeMaskCheck1 == maskShedule1);
Console.WriteLine(officeMaskCheck2 == maskShedule2);