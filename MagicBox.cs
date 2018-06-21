using System;

namespace dotNet5776_01_2920_0267
{
    public class MagicBox : IExecutable
    {
        public void Execute()
        {
            int[,] box = new int[5, 5];
            Console.WriteLine("Enter a matrix in the following format:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("* * * * *");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < 5; j++)
                {
                    box[i, j] = Convert.ToInt32(row[j]);
                }
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    rowSum += box[i, j];
                }
                if (i == 0)
                    sum = rowSum;
                else if (rowSum != sum)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                int columnSum = 0;
                for (int j = 0; j < 5; j++)
                {
                    columnSum += box[j, i];
                }
                if (columnSum != sum)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            int lDiagonalSum = 0, rDiagonalSum = 0;
            for (int i = 0; i < 5; i++)
            {
                lDiagonalSum += box[i, i];
                rDiagonalSum += box[i, 4 - i];
            }
            if (rDiagonalSum != sum || lDiagonalSum != sum)
            {
                Console.WriteLine("NO");
                return;
            }
            Console.WriteLine("YES");
        }
    }
}

