/* Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив с указанием индексов
каждого элемента. */


int[,,] array = new int[3, 3, 3];

FillArray(array);
PrintArray(array);

void FillArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            for (int k = 0; k < array.GetLength(2); k++){
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
           for (int k = 0; k < array.GetLength(2); k++){
            Console.Write(array[i, j, k] + "  (" + i + j + k + ") ");
           }
        }
        Console.WriteLine(" ");
    }
}

