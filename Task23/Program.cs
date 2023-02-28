// Напишите программу, которая 
// принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
void Cube(int num)
{
  int index = 1;
  while (index<=num)
  {
    Console.WriteLine($"{index,5} - {Math.Pow(index,3),5}");
    index++;
  }
}

// решение через фор
// for(int index = 1;index<=n;index++) вместо кода стр 9, 10, 13