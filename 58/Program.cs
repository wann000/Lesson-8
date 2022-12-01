﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] ProductArray(int[,] array1, int[,] array2)
{
    int aRows = array1.GetLength(0); int aCols = array1.GetLength(1);
    int bRows = array2.GetLength(0); int bCols = array2.GetLength(1);
    int[,] sumProduct = new int[aRows, bCols];
    for (int i = 0; i < aRows; i++)
    {
        for (int j = 0; j < bCols; j++)
        {
            for (int k = 0; k < aCols; k++)
            {
                sumProduct[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return sumProduct;
}

Console.Clear();
Console.Write("Введите количество строк в матрице 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 1, равное числу строк матрицы 2: ");
int columns1 = int.Parse(Console.ReadLine()!);
int row2 = columns1;
Console.Write("Введите количество столбцов в матрице 2: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = GetArray(row1, columns1, 0, 9);
PrintArray(matrix1);
Console.WriteLine("Матрица 1: ");
int[,] matrix2 = GetArray(row2, columns2, 0, 9);
PrintArray(matrix2);
Console.WriteLine("Матрица 2: ");
int[,] productMatrix = ProductArray(matrix1, matrix2);
PrintArray(productMatrix);
Console.WriteLine("Результат: ");