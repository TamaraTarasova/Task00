// напишите программу которая 
// на вход принимает координаты двух точек
// и находит расстояние между ними в 2d пространстве
// метод
double Distance(int x1,int y1, int x2, int y2)
{
  double sumSquare = ((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
  double res = Math.Sqrt(sumSquare);
  return res; 
}

Console.WriteLine("Введите координаты точки 1");
Console.Write("x1:");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1:");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки 2");
Console.Write("x2:");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2:");
int numY2 = Convert.ToInt32(Console.ReadLine());
double result = Distance(numX1,numY1,numX2,numY2);
Console.Write(Math.Round (result,2,MidpointRounding.ToZero));