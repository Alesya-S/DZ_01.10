/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int [] array = new int [6];

newArray (array);
printArray(array);
numFind(array);

void newArray(int[] array){
    for (int i = 0; i<array.Length; i++)
    {
      array [i] = new Random().Next(0, 10);
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
    int sum = 0;
    {
    for(int i = 0; i <array.Length; i+=2)
       {
        sum = sum + array[i];
       }
        Console.WriteLine($"Сумма элементов на нечетных позициях равна {sum} ");
    }
    Console.WriteLine();
}