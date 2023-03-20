// // 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число m");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int numberN = int.Parse(Console.ReadLine());
int ackerman = Ackerman(numberM, numberN);
if (numberM < 0 | numberN < 0) Console.WriteLine(" Ошибка ввода");
else Console.WriteLine(ackerman);

int Ackerman(int m, int n)
{
  if (m == 0) return (n = n + 1);
  else if (n == 0) return Ackerman((m - 1), 1);
  else
    return Ackerman(m - 1, Ackerman(m, (n - 1)));
}