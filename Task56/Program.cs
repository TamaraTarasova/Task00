// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// Программа считает сумму элементов в каждой строке
//  и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка
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
void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.WriteLine("]");
}


int[] MinSumRows(int[,] matrix)
{
  int[] sumarray = new int[matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sum += matrix[i, j];
    }
    sumarray[i] = sum;
  }
  return sumarray;

}
int MinNumRow(int[] arr)
{
  int rowMin = 0;
  int minNum = arr[rowMin];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] < minNum)
    {
      minNum = arr[i];
      rowMin = i;
    }
  
  }
  return rowMin;
}
  int[,] array2d = CreateMatrixRndInt(4, 4, 0, 10);
  PrintMatrix(array2d);
  int[] sumRowsArray = MinSumRows(array2d);
  Console.WriteLine();
  PrintArray(sumRowsArray);
  int numMinRow = MinNumRow(sumRowsArray);

  Console.WriteLine($"Наименьшая сумма элементов {numMinRow} строке");





// if (rows!= columns) Console.WriteLine($"Ошибка ввода");
// else ReplaceRowsToColumns(array2d);

// PrintMatrix(array2d);


