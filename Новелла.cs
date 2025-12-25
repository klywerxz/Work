using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вы в лесу. Видите два пути:");
        Console.WriteLine("1. Пойти налево");
        Console.WriteLine("2. Пойти направо");

        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Вы пошли налево и нашли сундук!");
            Console.WriteLine("1. Открыть сундук");
            Console.WriteLine("2. Пройти мимо");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Конец 1: Вы нашли золото и стали богаты!");
            }
            else
            {
                Console.WriteLine("Конец 2: Вы прошли мимо и заблудились в лесу.");
            }
        }
        else
        {
            Console.WriteLine("Вы пошли направо и встретили волка!");
            Console.WriteLine("1. Попытаться убежать");
            Console.WriteLine("2. Залезть на дерево");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Конец 3: Вы убежали от волка и вышли к деревне!");
            }
            else
            {
                Console.WriteLine("Конец 4: Волк ушел, но вы застряли на дереве.");
            }
        }

        Console.WriteLine("Конец 5: Игра завершена! Спасибо за игру!");
    }
}