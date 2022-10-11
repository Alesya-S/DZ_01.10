/* Задача 13: Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

 if (n<=100)
{  
    Console.WriteLine("Третья цифра отсутствует");
}
  else 
{
    if (n>=1000)
    {
        n = n/10;
    Console.WriteLine("третья цифра числа" + Convert.ToString(n%10));
    }

    if (n>=100 || n<=1000)
    {
     Console.WriteLine("третья цифра числа" + Convert.ToString(n%10));
    }
}


    


