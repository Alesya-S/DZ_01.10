/*    int count = 0;
    {
    for(int i = 2; i <= count; i += 2)
    {
             Console.WriteLine(count);
    }
   //     Console.Write(array[i]+" ");
    }
    Console.WriteLine();*/


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
