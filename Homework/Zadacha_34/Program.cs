/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int [] array = new int [6];

newArray (array);
printArray(array);
numFind(array);

void newArray(int[] array){
    for (int i = 0; i<array.Length; i++)
    {
      array [i] = new Random().Next(99, 1000);
    }
    return;
}

void printArray(int[] array){
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void numFind(int[] array){
    int result = 0;
    {
    for(int i = 0; i <array.Length; i++)
       {
        if (array[i]%2==0)
        result++;
       }
        Console.WriteLine($"четных чисел в массиве {result} ");
    }
    Console.WriteLine();
}