

using System;

namespace My2DArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 2
            char[,] alphabet = new char[26, 2];
            int rows = alphabet.GetLength(0);
            Console.WriteLine("The rows of the array "+ rows);
            int columns = alphabet.GetLength(1);
            Console.WriteLine("The columns of the array "+ columns);
            Console.WriteLine("");
            //task 3
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        alphabet[i, j] = (char)(65 + i);
                    }
                    else
                    {
                        alphabet[i, j] = (char)(97 + i);
                    }
                }
            }
            //task 4
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(alphabet[i, j]);
                }
            }
        }
    }
}
