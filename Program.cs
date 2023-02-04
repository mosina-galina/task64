// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine() ?? "");
int c = 1;
Numbers(n,c);
void Numbers(int n, int i)
{
    if (i > n)
    {
        return;
    }
    else
    {
        Numbers(n, i + 1);
        Console.Write($"{i} ");
    }
}