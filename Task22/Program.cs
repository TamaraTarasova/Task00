// написать программу, которая 
// принимает число N
// выдает таблицу квадратов чисел от 1 до N
Console.WriteLine("Ведите число");
int number = Convert.ToInt32(Console.ReadLine());
Sqwear(number);
void Sqwear(int num)
{
  int index = 1;
  while (index<=num)
  {
    Console.WriteLine($"{index,5} - {index*index,5}");
    index++;
  }
}

// решение через фор
// for(int index = 1;index<=n;index++) вместо кода стр 9, 10, 13