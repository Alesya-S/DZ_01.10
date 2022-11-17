/*Задача 57/ Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза */

int n = 3;
int m = 3;
int[,] array = new Int32[n, m];
int[] diction = new int[(n * m) + 1];

randomFilling(array, 0, 10);
arrayOutput(array);
Console.WriteLine(" ");
frequencyDictionaryOfElements(array);

void randomFilling(int[,] arr, int min, int max){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void frequencyDictionaryOfElements(int[,] arr){       
    Dictionary<int, int> elementCounts = new Dictionary<int, int>();
    for(int i = 0; i < n; i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            int element = array[i, j];
            if (elementCounts.ContainsKey(element))
                elementCounts[element]++;
            else
                elementCounts.Add(element, 1);
        }
    }
        Console.WriteLine("Сколько одинаковых элементов?");
        foreach(KeyValuePair<int,int> count in elementCounts){
            Console.WriteLine("Элемент: {0} Count: {1}", count.Key, count.Value);
        }
    Console.WriteLine(" ");
}

void arrayOutput(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}