// Напишите программу, которая 
// принимает на вход число N
// выдает произведение чисел от 1 до N

Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>0)
{
int factorial = Factorial(number);
Console.WriteLine ($"Произведение чисел от 1 до {number} = {factorial}");
}
else Console.WriteLine ("ошибка ввода");

int Factorial(int num)
{
  int result = 1;
  int i = 1;
  while (i<=num)
  {
    result = result * i;
    i++;
  }
  return result;
}

// for (int i = 1; i <= num; i++)
// {
//   result = result * i;
// }
// return result;