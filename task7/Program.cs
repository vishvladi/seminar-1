﻿Console.WriteLine("Введите трехзначное число");
int n = int.Parse(Console.ReadLine());
int a = (n % 100) / 10;
Console.WriteLine(a + " - вторая цифра");

