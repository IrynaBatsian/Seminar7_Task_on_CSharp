// Задача46. Задайте двумерный массив размером m x n, заполненный случайными целыми числами.

void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(-10, 11);
      Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размеры матрицы m и n: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])]; // указываем int.Parse чтобы не заводить новую переменную для каждого элемента.
InputMatrix(matrix); // Вызываем заполнение двумерного массива и вывод.
