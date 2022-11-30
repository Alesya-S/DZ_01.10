/* Задача 66. Задайте значение M и N. Напишите программу, которая найдет сумму 
натуральных элементов в промежутке от M д N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
    return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}