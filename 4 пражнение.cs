using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        int money = Convert.ToInt32(Console.ReadLine());
        int result;

        if (money < 100)
            result = money + money * 5 / 100;  // +5%
        else if (money <= 200)
            result = money + money * 7 / 100;  // +7%
        else
            result = money + money * 10 / 100; // +10%

        Console.WriteLine("Итог: " + result);
    }
}