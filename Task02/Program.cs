//Напишите программу, которая
// на вход принимает 2 числа и 
// выдвет, какое из них большее  

Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
  Console.WriteLine($"{a} = max");
}
else
Console.WriteLine($"{b} = max");

