// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void CreateMatrix(int[,] arr, int[,] arr1)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < arr1.GetLength(0); m++)
    {
        for (int n = 0; n < arr1.GetLength(1); n++)
        {
            arr1[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arr, int[,] arr1)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            Console.Write($"{arr[m, n]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int m = 0; m < arr1.GetLength(0); m++)
    {
        for (int n = 0; n < arr1.GetLength(1); n++)
        {
            Console.Write($"{arr1[m, n]} ");
        }
        Console.WriteLine();
    }
}

void Proizved(int[,] arr, int[,] arr1, int[,] proizvedMatr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            proizvedMatr[m, n] = arr[m, n] * arr1[m, n];
        }
    }
}

void PrintProizvedMatrix(int[,] proizvedMatr)
{
    for (int m = 0; m < proizvedMatr.GetLength(0); m++)
    {
        for (int n = 0; n < proizvedMatr.GetLength(1); n++)
        {
            Console.Write($"{proizvedMatr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];
int[,] matrix1 = new int[4, 4];
int[,] proizvedMatrix = new int[4, 4];
Console.WriteLine($"Заданы два массива: ");
CreateMatrix(matrix, matrix1);
PrintMatrix(matrix, matrix1);
Console.WriteLine();
Console.WriteLine($"Произведение двух массивов будет равно следующему массиву: ");
Console.WriteLine();
Proizved(matrix, matrix1, proizvedMatrix);
PrintProizvedMatrix(proizvedMatrix);


