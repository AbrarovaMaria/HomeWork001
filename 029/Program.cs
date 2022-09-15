// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Введите числа: ");
        string number = Console.ReadLine(); 
        string[] array = new string[number.Length];
        int index = 0;
        foreach (var item in number) 
        {
            if(item != ',' || item !=' ')
            {
             array[index] += item.ToString();
            }else{
              index++;
            }
        }
        Console.Write("[ "); 
        for(int i = 0; i<=index-1; i++)
        {
            Console.Write(array[i] + ", "); 
        }
        Console.Write(array[index] + " ]");
    }
}