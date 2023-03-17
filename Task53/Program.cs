﻿// Задайте двумерный массив. Потом напишите программу
// которая поменяет местами первую и последнюю строку массива

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
      Console.Write($"{matrix[i,j], 4}, ");
      
    }
    Console.WriteLine("]");
  }
}
void Replace(int[,]matrix)
{
  int firstRow = 0;
  int LustRow = matrix.GetLength(0)-1;
  for (int j = 0; j <matrix.GetLength(1); j++)
  {
    int temp = matrix[firstRow,j];
    matrix[firstRow,j] = matrix[LustRow, j];
    matrix[LustRow, j] = temp;
     
  }
  }
int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
Replace(array2d);
PrintMatrix(array2d);
