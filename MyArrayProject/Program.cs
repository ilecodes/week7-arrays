

using System;
using System.Security.Cryptography;

namespace MyArrayProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 2
            char[] alphabet = new char[26];
            //task 3
            Console.WriteLine("Populate the array");
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
                Console.WriteLine(alphabet[i]);
            }
            //task 4
            Console.WriteLine("Printed in Reverse order");
            for (int i = alphabet.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(alphabet[i]);
            }
            //task 5
            Console.WriteLine("Modify the array");
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(65 + i);
                Console.WriteLine(alphabet[i]);
            }
            // task 6
            int[] fibonacci = {13,1,2,3,5,8,1,34,21,55};
            // task 7
            Console.WriteLine("Find Maximum");
            int max = 0;
            for (int i = 0;i < fibonacci.Length; i++)
            {
                if (fibonacci[i] > max) 
                { max = fibonacci[i]; }
            }
            Console.WriteLine("Largest Value in Array:" + max);
            // task 8
            Console.WriteLine("Sort the Array");
            Array.Sort(fibonacci);
            foreach (int i in fibonacci)
            {
                Console.WriteLine(i);
            }
            // task 9
            Console.WriteLine("Search for 34");
            int index = -1;
            int numtoFind = 34;
            for (int i =0 ; i < fibonacci.Length; i++)
            {
                if (fibonacci[i]== numtoFind)
                {
                    index = i;
                }
            }
            Console.WriteLine("The num is found at " + index);
        }
    }
}
