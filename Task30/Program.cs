// Напишите программу, которая 
// выводит массив из 8 элементов, 
// заполненный нулями и 1 в случайном порядке
// [1,0,0,1,1,1,0,1] 

Console.WriteLine("Сколько элементов в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = NewArray(num, 0, 1);
Console.WriteLine($"Полученный массив из {num} элементов");
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
  for (int i = 0; i < array.Length; i++)
  {
   Console.Write($"{array[i]}"); 
  }
}
