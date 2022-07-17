// Задача 57. Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

void CreateArray(int[,] arr)
{
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            arr[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] arr)
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

int n = 4;
int m = 5;
int[,] array = new int[n, m];

CreateArray(array);
PrintArray(array);
Console.WriteLine();


int[,] dictionary = new int[n * m, 2];
int k = 0;

bool exist = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        exist = false;
        for (int s = 0; s < k; s++)
        {
            if (dictionary[s, 0] == array[i, j])
            {
                dictionary[s, 1]++;
                exist = true;
                break;
            }
        }
        if (exist == false)
        {
            dictionary[k, 0] = array[i, j];
            dictionary[k, 1]++;
            k++;
        }
    }
}
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < dictionary.GetLength(1); j++)
    {
        Console.Write($"{dictionary[i, +j]} ");
    }
    Console.WriteLine();
}