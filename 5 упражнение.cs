using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        int money = Convert.ToInt32(Console.ReadLine());
        int result;
        int bonus = 15;

        if (money < 100)
            result = money + money * 5 / 100 + bonus;
        else if (money <= 200)
            result = money + money * 7 / 100 + bonus;
        else
            result = money + money * 10 / 100 + bonus;

        Console.WriteLine("Итог с бонусом: " + result);
    }
}