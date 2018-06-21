using System;

namespace dotNet5776_01_2920_0267
{
    static class Utils
    {
        public static bool InRange(int value, int min, int max)
        {
            return min <= value && value <= max;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Menu.Start(new Option[]
                {
                    new Option("Random numbers guessing game", new RandomGuess()),
                    new Option("Magic Box checking", new MagicBox())
                });
        }
    }
}
