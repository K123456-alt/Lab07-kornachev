// Console.WriteLine("Hello, World!");

// Задание 1.1
// String[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = days.Length -1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

//Задание 1.2
// double[] temps = { -5, -2, 0, 3, 7, 12, 9 };
//         foreach (double t in temps)
//         {
//             Console.Write(t + " ");
//         }
//         Console.WriteLine();

// Задание 2
//  int[] prices = { 120, 45, 300, 80, 15, 210 };
//         int sum = 0;
//         int countMore100 = 0;

//         foreach (int p in prices)
//         {
//             sum += p;
//             if (p > 100) countMore100++;
//         }

//         double average = (double)sum / prices.Length;
//         Console.WriteLine($"Сумма: {sum}");
//         Console.WriteLine($"Средняя цена: {average}");
//         Console.WriteLine($"Товаров дороже 100: {countMore100}");

// Задание 3
//  int[] prices = { 120, 45, 300, 80, 15, 210 };
//         int min = prices[0];
//         int maxIndex = 0;
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min) min = prices[i];
//     if (prices[i] > prices[maxIndex]) maxIndex = i;
// }
// Console.WriteLine($"Минимальная цена: {min}");
// Console.WriteLine($"Индекс самого дорогого товара: {maxIndex}");

// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0) balance[i] = 0;
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Console.WriteLine();

// Задание 5
// int[] numbers = new int[5];
// Console.WriteLine("Введите 5 целых чисел: ");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("В обратном порядке:");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();
// int Count = 0;
// foreach (int n in numbers)
// {
//     if (n % 2 == 0) Count++;
// }
// Console.WriteLine($"Чётных: {Count}");

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя: ");
// string search = Console.ReadLine();
// int foundIndex = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == search)
//     {
//         foundIndex = i;
//         break;
//     }
// }
// Console.WriteLine(foundIndex >= 0 ? $"Позиция: {foundIndex}" : "Не найдено");

// Задача "Журнал оценок"
// int[] grades = new int[8];
// Console.WriteLine("Введите 8 оценок (от 2 до 5):");
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }
// Console.Write("Оценки: ");
// foreach (int g in grades)
// {
//     Console.Write(g + " ");
// }
// Console.WriteLine();
// int sum = 0;
// foreach (int g in grades) sum += g;
// double average = (double)sum / grades.Length;
// Console.WriteLine($"Средняя оценка: {average:F2}");
// int max = grades[0];
// int min = grades[0];
// for (int i = 1; i < grades.Length; i++)
// {
//     if (grades[i] > max) max = grades[i];
//     if (grades[i] < min) min = grades[i];
// }
// Console.WriteLine($"Наибольшая оценка: {max}");
// Console.WriteLine($"Наименьшая оценка: {min}");
// int twos = 0;
// int fives = 0;
// foreach (int g in grades)
// {
//     if (g == 2) twos++;
//     if (g == 5) fives++;
// }
// Console.WriteLine($"Двоек: {twos}");
// Console.WriteLine($"Пятёрок: {fives}");
// if (average >= 4.5)
//     Console.WriteLine("Отличник");
// else if (average >= 3.5)
//     Console.WriteLine("Хорошист");
// else
//     Console.WriteLine("Есть над чем поработать");

// Доп задание
// int[] arr = { 1, 2, 3, 4, 5, 6 };
// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = temp;
// }
// foreach (int x in arr) Console.Write(x + " ");
// Console.WriteLine();