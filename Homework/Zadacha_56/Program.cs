/* Задача 56. Задайте прямоуголный двумерный массив. Напишите программу, которая будет
находить строчку с наименьшей суммой. */

Console.Write("Введите высоту матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длинну матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] array = new int [m,n];

FillArray(array);
Print(array);
//SumLineElements(array);
smallestSumOfRowElement(array);
Print(array);

void smallestSumOfRowElements(int[,] arr){
    int sum = 0;
    int smallestSum = 0;
    int row = 0;
    
    for (int i = 0 ; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if(i == 0){
            smallestSum = sum;
        }
         
        if(smallestSum > sum) {
            Console.WriteLine($"");
            smallestSum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.Write($"строка с наименьшей суммой элементов: {row + 1}");
}


/*int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");*/


/*void SumLineElements (int[,] arr){
    int sum = 0;
    int index = 0;
       for  (int i = 0; i < array.GetLength(1); i++){  
            int temp = 0;    
        for (int j = 0; j < array.GetLength(0); j++){
            temp += array [j,i];
        }
        if (temp > sum)
            {  
               sum = temp;
               index = i;
            }
    }
    Console.WriteLine ($"Столбец: ");
    for  (int i = 0; i < array.GetLength(1); i++){
        Console.WriteLine (array[i, index]);
    }
    Console.WriteLine ($"Строка с наименшей суммой элементов: {temp+1}");*/
       // Console.WriteLine($"\n{row+1} - строки с наименьшей суммой ({minsum}) элементов ");

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
