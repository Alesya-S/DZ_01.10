/* Задача 58. Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

int [,] array1 = new int [4,4];
int [,] array2 = new int [4,4];
int [,] array3 = new int [4,4];


FillArray(array1);
Print(array1);
FillArray(array2);
Print(array2);
Print(MultiplicationArray (array1, array2));

int[,] MultiplicationArray(int[,] array1, int[,] array2){       
    for (int i = 0; i < array1.GetLength(0); i++){
        for (int j = 0; j < array2.GetLength(1); j++){
            array3[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++){
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
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

