// Площадь треугольника. Пользователь вводит 6 целых чисел x1 y1 x2 y2 x3 y3 - координаты вершин треугольника. все числа не превышают 10(6степени) по абсолютной величине. Нужно узнать длины сторон и площадь этого треугольника.

 // Площедь треугольника будем вычислять через площадь герона S = корень из (полупериметр p*(p-a)*(p-b)*(p-c)). р = (a+b+c)/2

 Console.Clear();

 string[] numbers = Console.ReadLine().Split(" ");
 double x1 = int.Parse(numbers[0]);
 double y1 = int.Parse(numbers[1]);
 double x2 = int.Parse(numbers[2]);
 double y2 = int.Parse(numbers[3]);
 double x3 = int.Parse(numbers[4]);
 double y3 = int.Parse(numbers[5]);
 double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
 double b = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
 double c = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
 double p = (a + b + c) / 2;
 Console.WriteLine(Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2));

 
