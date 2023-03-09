// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2


Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите массив длиной {size}");
int[] array = CreateArrayInt (size);
PrintArray (array);
int countPositivNum = CountPositivNum (array);
Console.WriteLine ($"Количество положительных чисел в массиве = {countPositivNum}");

int[] CreateArrayInt (int size)
{
    int[] arr = new int[size];
   
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountPositivNum (int[] num)
{
    int count =0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) count++;
    }
    return count;
}
