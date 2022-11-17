/* Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив с указанием индексов
каждого элемента. */



int [,] array = new int [4,4];

FillArray(array);
Print(array);
//SortArray(array);
Print(array);

/*void SortArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++){         
        for (int j = 0; j < arr.GetLength(1); j++){
            for (int k = 0; k < arr.GetLength(1); k++){
                if (arr[i, j] < arr[i, k]) {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            } 
        }   
    }
}*/

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

