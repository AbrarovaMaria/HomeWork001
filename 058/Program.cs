// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите число строк матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов матрицы A: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов матрицы B: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите диапазон чисел: ");
int range = Convert.ToInt32(Console.ReadLine());

//Первая матрица 
int[,] MartrixA = new int[m, n];
NewArray(MartrixA);
Console.WriteLine("Первая матрица:");
WriteArray(MartrixA);

//Вторя матрица 
int[,] MartrixB = new int[n, p];
NewArray(MartrixB);
Console.WriteLine("Вторая матрица:");
WriteArray(MartrixB);
//результат 
int[,] resultMatrix = new int[m, p];

Matrix(MartrixA, MartrixB, resultMatrix);
Console.WriteLine("Произведение матриц A и B:");
WriteArray(resultMatrix);

void Matrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}


void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}