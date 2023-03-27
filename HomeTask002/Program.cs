// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GeneratorRandomIntArray()
{
  int[,] FullRandomArray = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
  for (int i = 0; i < FullRandomArray.GetLength(0); i++)
  {
    for (int j = 0; j < FullRandomArray.GetLength(1); j++)
    {
      int FillRandom = new Random().Next(-50, 50);
      while (FillRandom == 0)
        FillRandom = new Random().Next(-50, 50);
      FullRandomArray[i, j] = FillRandom;
      Console.Write($"|{FullRandomArray[i, j]}\t|");
    }
    Console.WriteLine();
  }
  return FullRandomArray;
}

int SearchValues(int[,] array, int[] size)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == size[0] && j == size[1])
        return array[i, j];
    }
  }
  return 0;
}

void PrintResult(int result, int[] size)
{
  if (result != 0)
    Console.WriteLine($"Позиция {size[0]},{size[1]} содержит значение {result}");
  else
    Console.WriteLine($"Позиция {size[0]},{size[1]} не существует");
}

Console.Clear(); Console.Write("Введите позицию элемента двумерного массива через запятую N,N: ");
int[] size = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
PrintResult(SearchValues(GeneratorRandomIntArray(), size), size);