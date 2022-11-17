/* Задача 56. Задайте прямоуголный двумерный массив. Напишите программу, которая будет
находить строчку с наименьшей суммой. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/

int[,] array = new int[5,3];
FillArray(array);
Print(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++){
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine){
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

int SumLineElements(int[,] array, int i){
    int sumLine = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++){
        sumLine += array[i,j];
    }
    return sumLine;
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
} 
