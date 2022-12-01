// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetArray(int a, int b, int c, int minValue, int maxValue)
{
    int[,,] result = new int[a, b, c];

    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }

    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($" Число {inArray[i,j,k]}\t в ячейке с координатами {i}, {j}, {k}");
            }
        }
    }
}
Console.Clear();
Console.Write("Введите длину массива: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите ширину массива: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Введите высоту массива: ");
int h = int.Parse(Console.ReadLine()!);
int[,,] array = GetArray(x, y, h, 10, 99);
PrintArray(array);

Console.WriteLine();