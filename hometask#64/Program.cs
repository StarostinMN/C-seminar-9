/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8 */
Console.Clear();

int Step = 2;

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
M = M + Math.Abs(M % Step);

Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = N - Math.Abs(N % Step);

PrintValue(M, N, Step);

void PrintValue(int min, int max, int step)
{
    if (min > max) return;
    Console.Write($"{min} ");
    PrintValue(min + step, max, step);
}
Console.WriteLine();
