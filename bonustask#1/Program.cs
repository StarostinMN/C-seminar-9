/* Дополнительная задача (задача со звёздочкой): Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();

Console.Write("Введите первое натуральное число: ");
double M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе натуральное число: ");
double N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {M}; n = {N} -> A ({M}, {N}) = {GetAckerman(M, N)}");

double GetAckerman(double m, double n)
{
    if (m == 0) { return n + 1; }
    else if (n == 0) { return GetAckerman(m - 1, 1); }
    else { return GetAckerman(m - 1, GetAckerman(m, n - 1)); }
}
