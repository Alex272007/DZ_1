Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 7 * 23;
// Проверяем какое число кратное одновременно и 7 и 23(7 * 23 = 161)
if (num % a == 0)
{
    Console.WriteLine($"Число {num} одновременно кратно 7 и 23"); 
}
else
{
    Console.WriteLine($"Число {num} одновременно не кратно 7 и 23");
}