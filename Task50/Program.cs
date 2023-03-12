// Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],4}, ");

    }
    Console.WriteLine("]");
  }
}

int NumberElems(int[,] matrix, int i, int j)
{

  if (i > matrix.GetLength(0) | j > matrix.GetLength(1)) Console.WriteLine("Такого элемента нет");
  int number = matrix[i, j];
  return number;
}
Console.WriteLine("Введите координаты элемента массива i= ");
int numI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты элемента массива j= ");
int numJ = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
int numberElems = NumberElems(array2d, numI, numJ);
Console.WriteLine(numberElems);
