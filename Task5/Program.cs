// Задача51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали ( с индексами (0, 0); (0, 1) и т.д.)


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


int RealiseMatrix(int[,] matrix)
{
  int sum = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == j && j != matrix.GetLength(1) - 1 && i != matrix.GetLength(0))
      {
        sum += matrix[i, j];
        Console.Write($"{matrix[i, j]} + ");
      }
      else if (i == j)
      {
        sum += matrix[i, j];
        Console.Write($"{matrix[i, j]} = ");
      }
    }
  }
  return sum;
}

Console.Clear();
Console.Write("Введите размеры матрицы i и j: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])]; // указываем int.Parse чтобы не заводить новую переменную для каждого элемента.
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix); // Вызываем заполнение двумерного массива и вывод.
Console.WriteLine();
Console.WriteLine("Результат: ");
Console.WriteLine(RealiseMatrix(matrix));

