// Написать программу, которая
// принимает на вход 3 числа 
// и выдает максимальное
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max ) max = a;
if (b > max ) max = b; 
if (c > max ) max = c;

  Console.Write("max = ");
Console.WriteLine(max);
