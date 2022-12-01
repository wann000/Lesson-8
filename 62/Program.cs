// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int[,] SpiralFillArray(int a)
{
    int size = a;
    int[,] fillMass = new int[size, size];
    int row = 0;
    int col = 0;
    for (int i = 1; i <= size * size; i++)
    {
        fillMass[row, col] = i;
        if (row <= col + 1 && row + col < size - 1) col++;
        else if (row < col && row + col >= size - 1) row++;
        else if (row >= col && row + col > size - 1) col--;
        else row--;
    }
    return fillMass;
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
Console.Clear();
Console.Write("Введите длину квадратного массива: ");
int dim = int.Parse(Console.ReadLine()!);
PrintArray(SpiralFillArray(dim));