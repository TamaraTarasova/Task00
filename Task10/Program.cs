///* 11. Напишите программу, которая выводит случайное
// трёхзначное число и показывает вторую цифру этого
// числа.*/
int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
 int firstDigit = number % 100;
 int lastDigit = number % 10;
int result =(firstDigit - lastDigit)/10;
Console.WriteLine (result);
