// по заданному номеру четверти 
// показать дипазон возможных координат точек (х и у)


string Quarter(string quart)
{
  if (quart == "1") return "x > 0, y > 0";
  if (quart == "2") return "x < 0, y > 0";
  if (quart == "3") return "x < 0, y < 0";
  if (quart == "4") return "x > 0, y < 0";
  return "неверные данные";
}

Console.Write("Введите номер четверти:");
string num = Console.ReadLine();
string result = Quarter(num);
Console.WriteLine(result);