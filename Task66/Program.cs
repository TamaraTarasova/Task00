// 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число N");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int numberTwo = int.Parse(Console.ReadLine());
int sumNumbers = PrintSumNumber(numberOne, numberTwo);
Console.Write($"Сумма чисел равна {sumNumbers}");

int PrintSumNumber(int num1, int num2)
{
  if (num1 > num2)
    return num1 + PrintSumNumber(num1 - 1, num2);

  else if (num2 > num1)
  {
    return num2 + PrintSumNumber(num2 - 1, num1);
  }
  else

    return num1;

}
