// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N
Console.WriteLine("Введите число N");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int numberTwo = int.Parse(Console.ReadLine());

PrintNumber(numberOne, numberTwo);

void PrintNumber(int num1, int num2)
{
  if (num1 > num2)
  {
    Console.Write($"{num1} ");
    PrintNumber(num1 - 1, num2);
  }
  else if (num2 > num1)
  {
    PrintNumber(num1, num2 - 1);
    Console.Write($"{num2} ");
  }
  else
  {
    Console.Write($"{num2 } ");
  }
}
