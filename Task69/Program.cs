// 69 Напишитепрограмму, которая 
// на вход принимает 2 числа А и В, 
// и возводит число А в целую степень В 
// с помощью рекурсии 

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console. WriteLine("Введите степень числа");
int power = int.Parse(Console.ReadLine());
if (power < 0) Console.WriteLine("Ошибка ввода");
else Console.WriteLine($"{number}, {power} = {PowerRecMath(number, power)}");

// int PowNumber(int num, int pow)
// {
//   if(pow == 0) return 1;
//   else return num * PowNumber(num, pow - 1);
// }
// Console.WriteLine($"{number}. {power} = {PowNumber(number, power)}");

int PowerRecMath(int a, int n) // второй способ
{
  if (n == 0) return 1;
  else if (n % 2 == 0) return PowerRecMath(a * a, n/2);
  else return PowerRecMath(a, n-1)*a; 

}
