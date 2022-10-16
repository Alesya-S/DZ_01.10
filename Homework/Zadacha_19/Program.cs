/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */



Console.WriteLine("введите число"); //ввели текст
string number = Console.ReadLine(); //преобразовали в строку
char[] arr = number.ToCharArray(); //заисали в масив
Array.Reverse(arr); //перевернули массив
string number2 = new String(arr); //новая строка
 
if (number == number2) 
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Нифига не палиндром");
}