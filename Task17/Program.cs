// На вход принимаются координаты точки(X и Y), 
// причем x и y не равны 0
// выдать номер четверти плоскости, 
// в которой находится эта точка

Console.WriteLine("Введите координаты точки");
Console.Write("x:");
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int yc = Convert.ToInt32(Console.ReadLine());
int quarter = Quarter(xc, yc);
string result = quarter > 0
        ? $"Указанные координаты соответствуют четверти {quarter}"
        : "Введены некорректные координаты"; //тернарный оператор
Console.WriteLine(result);
int Quarter(int x, int y)
{
  if (x > 0 && y > 0) return 1;
  if (x < 0 && y > 0) return 2;
  if (x < 0 && y < 0) return 3;
  if (x > 0 && y < 0) return 4;
  return 0;
}