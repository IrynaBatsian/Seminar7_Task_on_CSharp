// Задача49. Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, и замените  эти элементы на их квадраты.

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 11);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}


void RealiseMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i % 2 == 1 && j % 2 == 1)
          matrix[i, j] *= matrix[i, j];
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размеры матрицы i и j: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])]; // указываем int.Parse чтобы не заводить новую переменную для каждого элемента.
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix); // Вызываем заполнение двумерного массива и вывод.
Console.WriteLine();
Console.WriteLine("Результат: ");
RealiseMatrix(matrix);