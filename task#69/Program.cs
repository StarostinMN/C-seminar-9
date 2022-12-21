/* Решение в группах задач:
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Clear();

Console.Write("Введите возводимое в степень число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите показатель степени: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} ^ {B} = {ComputePow(A, B)}");

int ComputePow(int a, int b)
{
    if (b == 0) return 1;
    return a * ComputePow(a, b - 1);
}
