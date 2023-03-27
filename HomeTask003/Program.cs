// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateIntArray(int[] sizeArray)
{
  int[,] array = new int[sizeArray[0], sizeArray[1]];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 11);
      Console.Write($"|{array[i, j]}\t|");
    }
    Console.WriteLine();
  }
  Console.WriteLine("---");
  return array;
}

void ArithmeticMean(int[,] array)
{
  double arithmetic = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      arithmetic += array[i, j];
    }
    Console.Write($"|{Math.Round(arithmetic / array.GetLength(0), 1)}\t|");
    arithmetic = 0;
  }
}

Console.Clear(); Console.Write("Введите размер массива через дефис N-N: ");
int[] sizeArray = Console.ReadLine().Split("-").Select(x => int.Parse(x)).ToArray();
ArithmeticMean(CreateIntArray(sizeArray));