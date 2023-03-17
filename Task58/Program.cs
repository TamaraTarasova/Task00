// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultiplicationMatrix(int[,]matrix1, int[,]matrix2)
{
  int[,] multiplicationMatrix = new int [matrix1.GetLongLength(0), matrix2.GetLength(1)];
  for (int i = 0; i <matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
    for (int x = 0; x < matrix2.GetLength(0); x++)
    {
      multiplicationMatrix [i,j] += matrix1[i,x]*matrix2[x,j];
     
    }
  }
 }
return multiplicationMatrix;
}

int[,] array2d1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array2d1);
Console.WriteLine();
int[,] array2d2 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(array2d2);
int rows = array2d1.GetLength(0);
int columns = array2d2.GetLength(1);
int[,] resultMatrix = MultiplicationMatrix(array2d1,array2d2);
if (rows!= columns) Console.WriteLine($"Ошибка ввода");
else MultiplicationMatrix(array2d1, array2d2);
Console.WriteLine();
PrintMatrix(resultMatrix);



