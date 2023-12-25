// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10; // 275 / 10 % 10 = 27 % 10 = 7
    int thirdDigit = number % 10; // 275 % 10 = 5
    // Math.Pow(5, 2) => 5 в 2 степени => 25
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"{number}: {secondDigit}^{thirdDigit} = {result}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}


// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int secondDigit = number / 10 % 10; // 275 / 10 % 10 = 27 % 10 = 7
    int thirdDigit = number % 10; // 275 % 10 = 5
    // Math.Pow(5, 2) => 5 в 2 степени => 25
    int result = (int)Math.Pow(secondDigit, thirdDigit);
    Console.WriteLine($"{number}: {secondDigit}^{thirdDigit} = {result}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
} 


// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет
// Получить 3 цифру числа с левой стороны (с начала)
// 12345679 -> 3
// 128 -> 8
// 23 - 3 цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int copyNumber = number;
if (number < 100)
{
    Console.WriteLine("3 цифры нет");
}
else
{
    while (number > 999) // В числе > 3 цифр
    {
        number /= 10; // number = number / 10
        // a = a * 50: a *= 50
        // a = a - 750: a -= 750
    }
    Console.WriteLine($"Третья цифра от: {copyNumber} = {number % 10} ");
}


// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("3 цифры нет, ЛИБО число отрц.");
}
else
{
    Console.WriteLine($"3 цифра от {number} = {number / 100 % 10}");
}
// 123 / 100 % 10 = 1  %  10 => 1