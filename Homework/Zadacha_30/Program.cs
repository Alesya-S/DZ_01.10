/* Задача 29: Напишите программу, которая задаёт массив произвольной длины,
заполняет произвольными элементами и выводит их на экран. Длину массива и элементы
массива можно задать рандомно или попросить пользователя ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


int [] numbers = new int[7];

Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
{
    numbers [i] = new Random().Next(0,9);
    Console.Write(numbers[i]); 
    if (i < (numbers.Length-1)) Console.Write($", ");
}
Console.Write("]"); 


/* int [] array = new int [8];
int len = array.Length;
int index = 0;

while (index < len)
{
    array [index] = new Random().Next(0,10);
    index ++;
}
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]); 
    if (i < (array.Length-1)) Console.Write($", ");
} */

