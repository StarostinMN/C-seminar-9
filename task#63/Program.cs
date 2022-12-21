/* Решение в группах задач:
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

PrintValue(1, N);

void PrintValue(int m, int max)
{
    if (m > max) return;
    Console.Write($"{m} ");
    PrintValue(m + 1, max);
}
Console.WriteLine();