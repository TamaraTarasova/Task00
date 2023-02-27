// необходимо написать программу которая 
// принимает на вход цифру, обозначающую день недели 
// выдает является ли день выходным
Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day <= 5)
{
Console.WriteLine("нет");
}
else if (day <=7)
{
   Console.WriteLine("да");
}
else Console.Write ("ошибка ввода");
