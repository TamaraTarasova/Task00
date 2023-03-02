// Напишите программу, которая 
// принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

int Cykle(int num)
{
  int newNum = 0;
     while (num!=0)
  {
    int intermediate=num % 10;
    num=num / 10;
    newNum = newNum * 10 + intermediate;
  }
  return newNum;
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = Cykle(number);
if (number == newNumber) Console.WriteLine("Число является полиндромом");
else  Console.WriteLine("Число не является полиндромом");
// Console.WriteLine($"Новое число:{newNumber}");
