// Напишите программу которая
// на вход принимаетчисло А
// выдает сумму чисел от 1 до А

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNumbers (number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");

int SumNumbers (int num)
{
  int sum = 0;
  for (int i = 1; i <= num; i++)//так как условие считать с 1 то i=1
  {
    sum = sum + i;
  }
  return sum;
}
