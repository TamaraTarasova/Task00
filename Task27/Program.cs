﻿// Напишите программу, которая 
// принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int diget = SumDigit(number);
Console.WriteLine($"Сумма цифр в числе{number} = {diget}");


int SumDigit(int num)
{
  int result = 0;
  while (num > 0)
  {
    result = result + num % 10;
    num = num / 10;
  }
  return result;
}


