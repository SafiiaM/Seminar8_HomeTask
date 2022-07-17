// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
// суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int Sum(int[,] arr)
{
    int sum = 0;
    int minSum = 0;
    int minLine = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += arr[m, n];
                minSum += arr[m, n]; 
            }
            else sum += arr[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minLine = m;
        }
        sum = 0;
    }
    return minLine;
}
int[,] matrix = new int[4, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(matrix));

