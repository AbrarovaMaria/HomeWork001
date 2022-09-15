//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
 //Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());                             
int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
}
Console.Write($"[{String.Join(", ", array)}]  -->  ");
Console.Write($"[{String.Join(", ", Array(array))}]");

int[] Array(int[] arrayB)
{
  int[] result;
  if (arrayB.Length % 2 == 0)
  {
    result = new int[(arrayB.Length / 2)];
    
    for (int i = 0; i < arrayB.Length / 2; i++)
    {
      result[i] = arrayB[i] * arrayB [arrayB.Length - 1 - i];
    }
  }
  else
  {
    result = new int[(arrayB.Length / 2 + 1)];
    for (int i = 0; i <= arrayB.Length / 2; i++)
    {
      if (arrayB.Length / 2 == i)
      {
        result[i] = arrayB[i];
      }
      else
      {
        result[i] = arrayB[i] * arrayB[arrayB.Length - 1 - i];
      }
    }
  }
  return result;
}