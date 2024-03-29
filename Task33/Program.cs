﻿// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
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

void InverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
       
}

int[] array = CreateArrayRndInt(12,-9,9);
PrintArray(array);
Console.WriteLine();
InverseArray(array);

bool FindArrayElement (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == num) return true;
    }    
    return false;
}

Console.WriteLine();
Console.WriteLine($"Введите искомое число - ");
int number = Convert.ToInt32(Console.ReadLine());
bool existNum = FindArrayElement (array, number);
Console.WriteLine(existNum ? "да" : "нет");