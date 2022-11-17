﻿/*Задача 61. Вывести первые N строк треугольника Паскаля.
Сделать вывод в виде равнобедренного треугольника
........1
......1 1
....1 2 1
..1 3 3 1
1 4 6 4 1
Точки в началах строк в примере решения проставлены, так как редактор игнорирует пробелы в начале строки
и выравнивает строки по левому краю.
Треугольник становится не равнобедренным, а прямоугольным.
В своем варианте решения попробуйте вывести равнобедренный треугольник без дополнительных точек.*/

int i, n, c;
Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
string s = Console.ReadLine();
n = Convert.ToInt32(s);
Console.WriteLine($"Ваше число {n}");

Console.WriteLine($"Треугольник Паскаля ");
pascalTriangle(n);

void pascalTriangle(int n){
    for (int line = 1; line <= n; line++){
        for (int j = 0; j <= (n - line); j++){
            Console.Write(" "); 
        }
        int c = 1;
        for (int i = 1; i <= line; i++){
            Console.Write(" ");
            Console.Write(c);
            c = c * (line - i) / i;
        }
        Console.WriteLine(" ");
    }
}