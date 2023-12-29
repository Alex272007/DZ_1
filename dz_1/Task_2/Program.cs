Console.Write("Введите координаты x: ");
int x_coordinates = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты y: ");
int y_coordinates = Convert.ToInt32(Console.ReadLine());

if (x_coordinates > 0 && y_coordinates > 0)
{
    Console.WriteLine("Эта точка в 1 координатной четверти плоскости!");
}
else if (x_coordinates < 0 && y_coordinates > 0)
{
    Console.WriteLine("Эта точка во 2 координатной четверти плоскости!");
}
else if (x_coordinates < 0 && y_coordinates < 0)
{
    Console.WriteLine("Эта точка в 3 координатной четверти плоскости!");
}
else 
{
    Console.WriteLine("Эта точка в 4 координатной четверти плоскости!");
}