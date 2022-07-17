// Задача 62. Заполните спирально массив 4 на 4.// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


    int a = 4; 
    int [,] SpiralMatrix = new int [a, a]; 

    int k = 1; // переменная, значением которой заполнятся массив, пока она не достигнет значения a*a
    int i = 0;
    int j = 0;

   while (k <= SpiralMatrix.GetLength(0) * SpiralMatrix.GetLength(1))
{
  SpiralMatrix[i, j] = k;
 k++;
  if (i <= j + 1 && i + j < SpiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(SpiralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
    
  