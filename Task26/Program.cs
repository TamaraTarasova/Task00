// Напишите программу, которая
// принимает на вход число
// выдает количество цифр в числе

Console.WriteLine("ВВедите число:");
int number = Convert.ToInt32(Console.ReadLine());
int diget = ChekDigit(number);
Console.WriteLine($"Количество цифр в числе{number} - {diget}");


int ChekDigit(int num)
{
  int result = 0;
  while (num != 0)
  {
    result = result + 1;
    num = num / 10;
  }
  return result;
}

