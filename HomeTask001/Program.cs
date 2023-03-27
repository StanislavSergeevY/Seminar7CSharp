// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RandomInArray(double[,] array)
{
  double randomValue = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      randomValue = Math.Round(new Random().NextDouble() * (30 - 10) - 10, 2);
      while (randomValue == 0)
      {
        randomValue = Math.Round(new Random().NextDouble() * (30 - 10) - 10, 2);
      }
      array[i, j] = randomValue;
      Console.Write($"|{array[i, j]}\t|");
    }
    Console.WriteLine();
  }
}

Console.Clear(); Console.Write("Введите размер многомерного массива через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] MatrixArray = new double[size[0], size[1]];
RandomInArray(MatrixArray);