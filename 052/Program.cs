//// Задача 52. Задайте двумерный массив из целых чисел. Найдите 
// cреднее арифметическое элементов в каждом столбце. 

Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");
int[,] array = new int [a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array [i,j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < b; j++)
{
    Console.WriteLine("Среднее арифметическое  = " + average(j));
}
double average(int column)
{
    double average = 0;
    double x = 0;
    for (int i = 0; i < a; i++)
    {
        average+= array [i, column];
    }
    x = average / a;
    return x;
}
