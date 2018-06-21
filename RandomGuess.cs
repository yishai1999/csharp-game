using System;

namespace dotNet5776_01_2920_0267
{
    public class RandomGuess : IExecutable
    {
        int[] numbers;

        public RandomGuess()
        {
            Random r = new Random();
            numbers = new int[100];
            for (int i = 0; i < 100; i++)
                numbers[i] = r.Next(1000);
        }

        public void Execute()
        {
            Menu.Start(new Option[]
                {
                    new Option("Number guessing", new NumberGuessing(numbers)),
                    new Option("Range Guessing", new RangeGuessing(numbers))
                });
        }

        class NumberGuessing : IExecutable
        {
            readonly int[] numbers;

            public NumberGuessing(int[] numbers)
            {
                this.numbers = numbers;
            }

            public void Execute()
            {
                Console.WriteLine("Guess a number between 0-1000");
                int num = Convert.ToInt32(Console.ReadLine());
                bool flag = true;
                for (int i = 0; i < 100; i++)
                {
                    if (numbers[i] == num)
                    {
                        Console.WriteLine("That number appears");
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("That number does not appear");
                }
            }
        }

        class RangeGuessing : IExecutable
        {
            readonly int[] numbers;

            public RangeGuessing(int[] numbers)
            {
                this.numbers = numbers;
            }

            public void Execute()
            {
                Console.WriteLine("Guess how many numbers are in a certain range");
                int min = Convert.ToInt32(Console.ReadLine());
                int max = Convert.ToInt32(Console.ReadLine());
                int amount = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                if (min > max)
                {
                    int temp = min;
                    min = max;
                    max = temp;
                }
                for (int i = 0; i < 100; i++)
                    if (Utils.InRange(numbers[i], min, max))
                        count++;
                Console.WriteLine("You're {0}", count == amount ? "right" : "wrong");
            }
        }
    }
}

