// 67. Напишите программу которая 
// будет принимать на вход число и 
// возвращать сумму его цифр

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
 int SumDigits(int num)
 {
  if (num == 0) return 0;
  else return num % 10 + SumDigits(num/10);
 }
Console.WriteLine($"{SumDigits(number)}");