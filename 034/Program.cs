// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
int count = 0;
Console.Write("В массиве [ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    if (array[i] % 2 == 0) count++;
    Console.Write(array[i] + " ");
    
}
Console.Write("]");
Console.WriteLine(" количество четных значений: " + count);