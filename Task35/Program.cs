﻿// Задайте одномерный массив из 123 случайных чисел.
// найдите количество элементов массива, значения которых лежат
//  в отрезке[10,99]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int CountTwoSignArray(int[] arr)
{
  int count = 0;
  for (int i = 0; i <arr.Length; i++)
  {
    if (arr[i]<100 && arr[i] >10) count++;
  }
  return count;
}

int[] array = CreateArrayRndInt(123, 0, 1000);
PrintArray(array);
Console.WriteLine();
int countTwoSignArray = CountTwoSignArray(array);
Console.WriteLine(countTwoSignArray);
