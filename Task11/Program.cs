﻿///* 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98 */
// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
//  int firstDigit = number / 100;
//  int lastDigit = number % 10;
// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine (result);
// вариант решения через метод
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
int newNumber = NewNumber(number);
Console.WriteLine (newNumber);
int NewNumber(int num)
{
 int firstDigit = num / 100;
 int lastDigit = num % 10;
int result = firstDigit * 10 + lastDigit;
return result;
}

