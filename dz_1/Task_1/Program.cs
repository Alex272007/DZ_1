﻿Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 & num % 23 == 0)
{
    Console.WriteLine($"Число {num} одновременно кратно 7 и 23"); 
}
else
{
    Console.WriteLine($"Число {num} одновременно не кратно 7 и 23");
}