/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
 [3 7 22 2 78] -> 76 */

 int [] array = new int [6];

newArray (array);
printArray(array);
numFind(array);

void newArray(int[] array){
    for (int i = 0; i<array.Length; i++)
    {
      array [i] = new Random().Next(-10, 10);
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
    int min = array[0];
    int max = array[0];
    {
    for(int i = 0; i <array.Length; i++)
       {
        if (array[i] > max)
        {
            max = array[i];
        }
         if (array[i] < min)
         {
            min = array[i];
         }
       }
       Console.WriteLine($"Максимальное значение = {max}, Минимальное значение = {min} ");
       Console.WriteLine($"Разница между максимальным и минимальным = {max-min} ");
    }
    Console.WriteLine();
} 