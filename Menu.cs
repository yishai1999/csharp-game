using System;

namespace dotNet5776_01_2920_0267
{
    public static class Menu
    {
        public static void Start(Option[] options)
        {
            int choice;
            do
            {
                for (int i = 1; i <= options.Length; i++)
                {
                    Console.WriteLine(" {0} -\t{1}", i, options[i - 1].description);
                }
                Console.WriteLine(" 0 -\tExit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                if (!Utils.InRange(choice, 0, options.Length))
                    Console.WriteLine("No such option, man!");
                else if (choice != 0)
                {
                    options[choice - 1].operation.Execute();
                    Console.WriteLine("---------------------\n");
                }
            } while (choice != 0);
        }
    }
}

