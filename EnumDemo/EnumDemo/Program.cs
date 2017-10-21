using System;

namespace EnumDemo
{    
    enum Suits
    {
        Hearts = 1,
        Spades,
        Diamonds = 4,
        Clubs,
    }

    [Flags]
    enum FileAccess
    {
        Read,
        Write,        
    }

    [Flags]
    enum Seasons
    {
        None = 0,
        Autumn = 1,
        Spring = 2,
        Winter = 4,
        Summer = 8
    }
    class Program
    {
        static void Main(string[] args)
        {
            Suits color = Suits.Hearts;
            Seasons season = Seasons.Autumn | Seasons.Winter;
            if (color == Suits.Hearts)
            {
                Console.WriteLine("Mam Hearts.");
            }
            // 0b00000010 - Spring
            // 0b00000110 - Spring | Winter
            // 0b00000010
            // 0b00000010 - Spring
            Seasons compare = Seasons.Summer;
            if ((season & compare) == compare)
            {
                Console.WriteLine($"Mam {compare}");
            }
            Console.WriteLine($"{color}, {season}");
        }
    }
}
