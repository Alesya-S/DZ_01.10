/* Задача 58. Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
 Например, даны 2 матрицы:
А В
1 4 | 3 5
3 5 | 1 2
Результирующая матрица будет:
С
7 13
14 25
Произведением двух матриц А и В называется матрица С, элемент которой,
находящийся на пересечении i-й строки и j-го столбца, равен сумме произведений
элементов i-й строки матрицы А на соответствующие (по порядку) элементы j-го столбца матрицы В.
С (0,0) = А(0,0) * B(0,0) + A(0,1) * B(1,0) = 1 · 3 + 4 · 1 = 3 + 4 = 7
С (0,1) = А(0,0) * B(0,1) + A(0,1) * B(1,1) = 1 · 5 + 4 · 2 = 5 + 8 = 13
С (1,0) = А(1,0) * B(0,0) + A(1,1) * B(1,0) = 3 · 3 + 5 · 1 = 9 + 5 = 14
С (1,1) = А(1,0) * B(0,1) + A(1,1) * B(1,1) = 3 · 5 + 5 · 2 = 15 + 10 = 25
Произведение двух матриц АВ имеет смысл только в том случае,
когда число столбцов матрицы А совпадает с числом строк матрицы В.
В произведении матриц АВ число строк равно числу строк матрицы А ,
а число столбцов равно числу столбцов матрицы В.*/

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

