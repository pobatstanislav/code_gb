using System;
using System.IO;

//2.	Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
string myTime = System.DateTime.Now.ToString("yyyy.MM.dd_HH.mm");
//Console.WriteLine(myTime);
File.AppendAllText("startup.txt", myTime + Environment.NewLine);


