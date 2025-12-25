using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int x = Convert.ToInt32(Console.ReadLine());

        if (x > 5 && x < 10)
            Console.WriteLine("Число больше 5 и меньше 10");
        else
            Console.WriteLine("Неизвестное число");
    }
}