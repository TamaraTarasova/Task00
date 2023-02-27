// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
PrintArray(array);
bool FindArrayElement (int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] == num) return true;
    }    
    return false;
}


int[] array = CreateArrayRndInt(12,-9,9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Введите искомое число - ");
int number = Convert.ToInt32(Console.ReadLine());
bool existNum = FindArrayElement (array, number);
Console.WriteLine(existNum ? "да" : "нет");