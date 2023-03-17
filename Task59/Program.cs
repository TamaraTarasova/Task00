// Задайте двумерный массив из целых чисел
// напишите программу, которая удалит строку и столбец, на пересечении которых
//  расположен наименьший элемент массива int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
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

int[] IndexMinElem(int[,] matrix)
{
  int rows = 0;
  int columns = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i, j] <= matrix[rows, columns])
      {
        rows = i;
        columns = j;
      }
    }
  }
  return new int[] { rows, columns };
}

int [,] DeleteRowColumn(int[,] matrix, int[] array)
{
  int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
  int m = 0, n = 0;
  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    if (m == array[0]) m++;
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      if (n == array[1]) n++;
      newMatrix[i, j] = matrix[m, n];
      n++;
    }
    m++;
    n = 0;
  }
  return newMatrix;
}
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] indexMinElem = IndexMinElem(array2d);
int[,] newarray2d = DeleteRowColumn(array2d, indexMinElem);
PrintMatrix(newarray2d);