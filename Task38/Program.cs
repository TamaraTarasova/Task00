// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRnddouble(int size, int min, int max)
{
  double[] arr = new double[size];
  Random rnd = new Random();
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.NextDouble()*((max - min) + min);
  }
  return arr;
}

void PrintArray(double[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write("]");
}
double MaxNumArray(double[] arr)
{
  double maxNum = 0;
  for (int i = 0; i < arr.Length; i++)

  {
    if (arr[i] > maxNum) maxNum = arr[i];
  }
  return maxNum;
}

double MinNumArray(double[] arr)
{
  double minNum = arr[1];
  for (int i = 1; i < arr.Length; i++)

  {
    if (arr[i] < minNum) minNum = arr[i];
  }
  return minNum;
}
double[] array = CreateArrayRnddouble(10, 5, 20);
PrintArray(array);
Console.WriteLine();
double diffmaxminnumArray = (MaxNumArray(array) - MinNumArray(array));
Console.WriteLine ($"Разница между максимальным и минимальным числом массива= {diffmaxminnumArray}");

