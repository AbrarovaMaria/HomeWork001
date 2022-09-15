// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[10];
Console.Write("В массиве [ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.Write("] ");
Console.WriteLine(" ");
Console.WriteLine("Максимальное значение = " + max + " минимальное = " + min);
Console.WriteLine("Разница между ними: " + (max - min));