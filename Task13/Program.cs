// Напишите программу, которая на вход принимает
// число и на выходе показывает 
// третью цифру  этого числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100) ;
while (number >= 999)
{
  number = number / 10;
  number++;
}

else Console.WriteLine("Вы ввели не трехзначное число!");
int result = number % 10;
Console.WriteLine(result);


