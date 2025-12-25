using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Выбрано сложение");
                break;
            case 2:
                Console.WriteLine("Выбрано вычитание");
                break;
            case 3:
                Console.WriteLine("Выбрано умножение");
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
    }
}