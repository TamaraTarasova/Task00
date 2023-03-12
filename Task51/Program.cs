﻿// Задайте двумерный массив. Найдите суммуэлементов
// находящихся на главной диагонали (с индексами (0,0);(1,1))
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
int MainDiagonalSumElems(int[,]matrix)
{
  int sum = 0;
  for (int i = 0; i <matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
     if (i==j)
     {
      sum+=matrix[i, j];
     } 
    }
  }
  return sum;
}
int[,] array2d = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);
int mainDiagonalSumElems = MainDiagonalSumElems(array2d);
Console.WriteLine ($"Сумма элементовглавной диагонали = {mainDiagonalSumElems}");