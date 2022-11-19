﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2    -0,2
// 1   -3,3    8    -9,9
// 8    7,8  -7,1     9

Console.Clear();
Console.Write("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
Random rnd = new Random();
FillArray(array);
Console.WriteLine();
PrintArray(array);


void PrintArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            Console.Write($"{matr[i, j]} "); 
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { 
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); 
        }
    }
}
