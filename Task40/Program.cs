// Задача 40: Напишите программу, которая 
// принимает на вход три
// числа и проверяет, может ли существовать треугольник
//  с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.WriteLine("Введите число 1:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int z = Convert.ToInt32(Console.ReadLine());

// int NumberInput(string msg)

// {
//     System.Console.Write(msg);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
bool InequalityTriangle(int a1, int b1, int c1)
{
    if (a1 >= b1 + c1 || b1 >= a1 + c1 || c1 >= a1 + b1) return true;
    else return false;
}

bool result=InequalityTriangle(X, y, z);
Console.WriteLine(result?"Да":"Нет");