

using System;
using System.Collections.Generic;

namespace MyListProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 2
            List<string> months = new List<string>();
            //task 3
            Console.WriteLine("Populating the Array");
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
            //task 4
            Console.WriteLine("Convert list to array");
            string[] monthNames = months.ToArray();
            for (int i = 0; i < monthNames.Length; i++)
            {
                Console.WriteLine(monthNames[i]);
            }
            // task 5
            Console.WriteLine("Remove from the list");
            int numberM = months.Count;
            Console.WriteLine("Length before: "+ numberM);
            months.Remove("September");
            months.Remove("November");
            numberM = months.Count;
            Console.WriteLine("Length after: " + numberM);
            //task 6
            Console.WriteLine("Search the list");
            string monthtoFind = "December";
            int index = months.IndexOf(monthtoFind);
            Console.WriteLine("The position of month: " + index);
        }
    }
}
