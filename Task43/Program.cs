// Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
double X = CoordinateIntersectionX (k1, b1, k2, b2);
double Y = CoordinateIntersectionY (k1, b1, X);
Console.WriteLine ($"Координаты точки пересечения прямых X = {X}, Y = {Y}");

double CoordinateIntersectionX (double x1,double y1,double x2, double y2)
{
    double resultX = (y2-y1)/(x1-x2);
    return resultX; 
}

double CoordinateIntersectionY (double x1,double y1, double resultX)
{
     
    double resultY = x1*resultX + y1;
    return resultY;
}