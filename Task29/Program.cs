// Напишите программу, которая 
// задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.WriteLine("Сколько элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = NewArray(num, 0, 10);
Console.WriteLine($"Полученный массив из [{num}] элементов");
PrintArray(arr);

// методы
int[] NewArray(int num, int min, int max)
{
  Random rand = new Random();
int[] arr = new int[num];
for (int i = 0; i < num; i++)
{
 arr[i] = rand.Next(min,max+1);  
}
return arr;
}
void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
   Console.Write($"{ array[i] }");
   if(i<array.Length-1) Console.Write(", ");
  }
  Console.Write("]");
}
