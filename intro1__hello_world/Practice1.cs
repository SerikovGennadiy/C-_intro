using System;

namespace intro1__hello_world
{
    class Practice1
    {
        static void Main()
        {
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.Write("Сколько тебе лет? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Привет {name}, лет которому(ой): {age}, сегодня {DateTime.Now:dd MMMM yyyy} года");
        }
    }
}
