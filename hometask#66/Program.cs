/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"M = {M}; N = {N} -> {(ComputeSumOFItems(M, N))}");

double ComputeSumOFItems(int min, int max)
{
    if (max < min) return 0;
    else return max + ComputeSumOFItems(min, max - 1);
}
