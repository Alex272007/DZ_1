Console.Write("Введите число  целое число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstDigit = number / 10;
int secondDigit = number % 10;
     
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit + " Наибольшая цифра числа.");
}
else if (firstDigit < secondDigit) 
{
    Console.WriteLine(secondDigit + " Наибольшая цифра числа.");  
}
else
{
    Console.WriteLine("Цифры равные");
}