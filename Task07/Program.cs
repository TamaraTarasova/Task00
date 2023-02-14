// Напишите программу, которая на вход принимает
// трехзначное число и на выходе показывает 
// последнюю цифру  этого числа
Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=100 && number <= 999)
{
  int LastNumber = number % 10;
  Console.Write($"последняя цифра числа- {LastNumber}");
}
else Console.WriteLine("Вы ввели не трехзначное число!");