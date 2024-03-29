﻿// Задайте двумерный массив.
// Найдите элементы, у которых оба индекса четные
// и замените эти элементы на их квадраты
int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++) 
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = rnd.Next(min, max+1);
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
      Console.Write($"{matrix[i,j], 3}, ");
    }
    Console.WriteLine("]");
  }
}

void ReplaceEvenElems(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i+=2)
  {
    for (int j = 0; j < array.GetLength(1); j+=2)
    {
      array[i,j]*=array[i,j];
    }
  }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);
ReplaceEvenElems(array2D);
Console.WriteLine();
PrintMatrix(array2D);
