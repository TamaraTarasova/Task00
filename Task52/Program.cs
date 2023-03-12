// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)// проход по столбцам
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
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
      Console.Write($"{matrix[i, j],5}, ");

    }
    Console.WriteLine("]");
  }
}

double[] ArithmeticMeanColumns(int[,] matrix)
{
  double[] mean = new double[matrix.GetLength(1)];
  
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum = sum + matrix[i, j];
    }
    mean[j] = sum / matrix.GetLength(0);
          mean[j] = Math.Round(mean[j], 2, MidpointRounding.ToZero);
  }

  return mean;
}

void PrintArray(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i], 5}, ");
    else Console.Write($"{arr[i],5}");
  }
  Console.Write("]");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
double[] arithmeticMeanColumns = ArithmeticMeanColumns(array2d);
Console.WriteLine();
Console.WriteLine("Средние арифметические столбцов равны:");
PrintArray(arithmeticMeanColumns);





