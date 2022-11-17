/* Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int [,] array = new int [4,4];

FillArray(array);
Print(array);
SortArray(array);
Print(array);

void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){         
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(1); k++){
                if (arr[i, j] > arr[i, k]) {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            } 
        }   
    }
}

void FillArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array [i,j] = new Random().Next(1,10);
        }
    }
}

void Print(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
} 


