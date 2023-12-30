Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int divider = 1;
int digit = 0;

 while (number / divider >= 10)
 {
    divider = divider * 10;
 }
 while (divider > 0)
 {
    digit = number / divider;
    number = number % divider;
    divider = divider / 10;
    Console.Write(digit + ", ");
 }