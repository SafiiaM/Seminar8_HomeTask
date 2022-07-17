// Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного
// треугольника

int InputLines(string input) // ввод строк 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.WriteLine();

void WriteArray(double[,] array) // заполнение массива 
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] != 0)
      {
          Console.Write($"{array[i, j]} ");
      }
      else Console.Write("  ");
    }
    Console.WriteLine();
  }
}

void FillPascalTriangle(double[,] pascalTriangle) // заполнение треугольника Паскаля
{
  for (int p = 0; p < pascalTriangle.GetLength(0); p++)
  {
    pascalTriangle[p, 0] = 1;
  }
  for (int i = 1; i < pascalTriangle.GetLength(0); i++)
  {
    for (int j = 1; j < i + 1; j++)
    {
      pascalTriangle[i, j] = pascalTriangle[i - 1, j] + pascalTriangle[i - 1, j - 1];
    }
  }
}

void TransformationPascalTriangle(double[,] array) // трансформация треугольника Паскаля
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int count = 0;
    for (int j = array.GetLength(1) - 1; j >= 0; j--)
    {
      if (array[i, j] != 0)
      {
        array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
        array[i, j] = 0;
        count++;
      }
    }
  }
  array[array.GetLength(0) - 1, 0] = 1;
}



int n = InputLines("Введите количество строк: ");

double[,] pascalTriangle = new double[n + 1, 2 * n + 1];

FillPascalTriangle(pascalTriangle);

Console.WriteLine();
WriteArray(pascalTriangle);

TransformationPascalTriangle(pascalTriangle);

Console.WriteLine();
WriteArray(pascalTriangle);

