using System;

while (true)
{
    Console.WriteLine("Введите x");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите  y");
    double y = Convert.ToDouble(Console.ReadLine());
    int R = 1;

    if ((y <= 0) && (x * x + y * y <= 1))
    {
        Console.WriteLine("Попадание");
    }
    else
    {
        Console.WriteLine("Промах");
    }

}
