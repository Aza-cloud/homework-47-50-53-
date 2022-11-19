// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет

Console.Clear();
Console.Write("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
FillArray(array);



void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Convert.ToInt32(new Random().Next(0, 15));
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t  ");
        Console.WriteLine();
    }
}


Console.Write("Введите первую координату: ");
int a = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите первую координату: ");
int b = Convert.ToInt32(Console.ReadLine() ?? "0");

void GetResult()
{
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        object c = array.GetValue(a, b);
        Console.WriteLine(c);
    }
}
GetResult();