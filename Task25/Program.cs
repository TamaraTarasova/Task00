// Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.

Console.WriteLine("Ведите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число В");
int numberB = Convert.ToInt32(Console.ReadLine());
int exponent = Exponent(numberA, numberB);
Console.WriteLine(exponent);

int Exponent(int a, int b)
{
  int result = 1;
  for (int i = 0; i < b; i++)
  {
    result = result * a;
  }
  return result;
}



