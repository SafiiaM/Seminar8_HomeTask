// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

void CreateMatrix(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m, n]} ");
        }
        Console.WriteLine();
    }
}

void DecreasingOrder(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            for (int d = 0; d < arr.GetLength(1) - n - 1; d++)
            {
                if (arr[m, d] < arr[m, d + 1])
                {
                    int t = arr[m, d];
                    arr[m, d] = arr[m, d + 1];
                    arr[m, d + 1] = t;
                }
            }
        }
    }
}

int[,] matrix = new int[3, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
DecreasingOrder(matrix);
PrintMatrix(matrix);

