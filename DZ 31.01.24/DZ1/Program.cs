﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void ShowNambers (int M, int N) // Рекурсивная функция для вывода чисел от M до N
{
    
    if (M > N)  // Если M больше N, рекурсия завершается
    {
        Console.Write(M);
        return;
    }
    Console.Write(M + " "); // Вывод M 
    ShowNambers(M + 1, N);  // Рекурсивный вызов с увеличением M на 1
}

Console.Write("Введите число M: "); // Вывод запроса на ввод числа M
int M = Convert.ToInt32(Console.ReadLine());  // Считывание введенного числа M и преобразование его в тип int
Console.Write("Введите число N: ");  // Вывод запроса на ввод числа N
int N = Convert.ToInt32(Console.ReadLine());  // Считывание введенного числа N и преобразование его в тип int


ShowNambers(M, N);  // Вызов рекурсивной функции
