/* Задача 64. адайте значение N. Напишите программу, коорая
выведет все натурвлные числа от N до 1. Выполнить с помощью рекурси.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
printNaturalNumbers(number);

void printNaturalNumbers(int n)
{
    int number = 1;
    if(n == number)
    {
    Console.Write(n);
    } 
    else
    {
    Console.Write(n+" ");
    printNaturalNumbers(n-1);
    }
}


