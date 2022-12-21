/* Решение в группах задач:
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
453 -> 12
45 -> 9 */

Console.Clear();

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {Number} равна {ComputeSumOfDigit(Number)}");

int ComputeSumOfDigit(int number)
{
    if (number / 10 == 0) return number % 10;
    return number % 10 + ComputeSumOfDigit(number/10);
}