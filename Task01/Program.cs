﻿// ввести 2 числа
// ответить является ли первое число квадратом второго

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a==b * b)
{
  Console.WriteLine($"{a}, квадрат {b}");
}
else
{
Console.WriteLine($"{a}, не квадрат {b}");
}


