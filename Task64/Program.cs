// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
NumbersFor(n, count);

void NumbersFor(int a, int count)
{
    if (count > a)
    {
        return;
    }
    else
    {
        NumbersFor(a, count + 1);
        Console.Write(count + " ");
    }
}
