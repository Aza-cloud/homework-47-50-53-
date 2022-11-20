// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(matrix);

int[,] GetMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)


{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void GetAverage()
{
    for (int i = 0; i < rows; i++)
    {
        int avr = 0;
        for (int j = 0; j < columns; j++)
        {
            avr = avr + matrix[i, j];

        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)avr / columns}");
    }
}
GetAverage();