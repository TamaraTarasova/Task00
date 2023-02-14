// Написать программу
// которая принимает число
// и определяет четное ли оно 
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 2;
if (result == 0) Console.Write ("да");
else Console.Write ("нет");
