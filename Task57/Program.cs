// Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том
// сколько раз встречается элемент входных данных
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

int[] MatrixToArray(int [,] matrix)
{
  int c = 0;
int[] array = new int[matrix.Length];
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    array[c] = matrix[i, j];
    c += 1;
  }
}
return array;
}
void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i<array.Length-1) Console.Write($"{array[i]}, ");
    else Console.WriteLine($"{array[i]}]");
  }
}
void SumElemArray(int[] array)
{
  int count = 1;
  int curentNumber = array[0];
  for (int i = 1; i < array.Length; i++)
  {
    if(array[i]==curentNumber) count ++;
    else 
    {
      Console.WriteLine($"число{curentNumber} встречается {count} раз.");
      curentNumber = array[i];
      count = 1;
    }
  }
  Console.WriteLine($"число{curentNumber} встречается {count} раз.");
}

int[,] matrix = CreateMatrixRndInt(3, 4, 1, 5);
int[] arr = MatrixToArray(matrix);

PrintMatrix(matrix);
Console.WriteLine();
PrintArray(arr);
Array.Sort(arr);
PrintArray(arr);
SumElemArray(arr);



