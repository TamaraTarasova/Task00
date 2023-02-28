// Напишите программу, которая на вход принимает
// число и на выходе показывает 
// третью цифру  этого числа или сообщает, что третьей цифры нет
int Cykl(int num)
{
  while (num > 999)
  {
    num=num / 10;
  }
  return num%10;
}
  Console.WriteLine("Введите число:");
  int number = Convert.ToInt32(Console.ReadLine());
  bool Threedigit(int number2)
  {
    return number2 < 100;
  }
int result = Cykl(number);
  if (Threedigit (number)) Console.WriteLine(" число не трехзначное !"); 
  Console.WriteLine(result);
   
  
  
