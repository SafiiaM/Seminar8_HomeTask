// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)



Console.WriteLine($"Введите координаты X: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координаты Y: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите координаты Z: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int[,,] Create3DArrayRndInt(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    var rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                array[i, j, s] = rnd.Next(10, 100);
            }

        }
    }
    return array;
}


static IEnumerable<int> UniqueRandomNumbers(int from, int to)
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];

        (values[i], values[j]) = (values[j], values[i]);
    }
}

int[,,] arr = new int[3, 4, 5];

IEnumerator<int> iterator = UniqueRandomNumbers(10, 99).GetEnumerator();
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int s = 0; s < arr.GetLength(2); s++)
            {
                if (!iterator.MoveNext())
                {
                    Console.WriteLine("Уникальные числа все вышли");
                    return;
                }
                else
                {
                    arr[i, j, s] = iterator.Current;
                }
            }
        }
    }
}

void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                if (s == 0) Console.Write("[");
                if (s < array.GetLength(2) - 1) Console.Write(array[i, j, s] + ", ");
                else Console.Write(array[i, j, s] + "]");
            }

        }
        Console.WriteLine();
    }
}

int[,,] matrix = Create3DArrayRndInt(num1, num2, num3);
Print3DArray(matrix);
WriteArray(matrix);


void WriteArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {

                Console.Write($"{array[i, j, s]} ({i}, {j}, {s}); ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

