/* Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7 */

Console.Clear();

Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());

int Min = M, Max = N;

if (M > N) {Min = N; Max = M;}

Console.WriteLine($"M = {M}; N = {N} -> НОД = {ComputeGreatestCommonDivisor(Max, Min)}");

int ComputeGreatestCommonDivisor(int max, int min)
{
    if (min == 0) {return max;}
    else {return ComputeGreatestCommonDivisor(min, max % min);}
}