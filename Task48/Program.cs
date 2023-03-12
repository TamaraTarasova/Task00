// Задайте двумерный массив размера m на n
// каждый элемент в массиве находится по формуле
// Amn=m+n
// выведите полученный массив на экран

int[,] CreateMatrixRndInt (int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  for (int i = 0; i < matrix.GetLength(0); i++) 
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i,j] = i+j;
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
      if(j < matrix.GetLength(1)-1) Console.Write($"{matrix[i,j], 3}, ");
      else Console.Write($"{matrix[i,j], 3}");
    }
    Console.WriteLine("]");
  }
}
int Promt(string message)
{
  Console.Write(message);
  string value = (Console.ReadLine());
  int result = Convert.ToInt32(value);
  return result;
}

int matrixRows = Promt("Введите количество строк: ");
int matrixColumns = Promt("Введите количество столбцов: ");
int[,] array2D = CreateMatrixRndInt(matrixRows, matrixColumns);
PrintMatrix(array2D);