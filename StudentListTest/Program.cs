using StudentListProject2;
using System;
using System.Collections.Generic;
namespace StudentListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student3> students = new List<Student3>();
            int Age = 0;
            string Name = " ";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Name pls");
                Name = Console.ReadLine();
                Console.WriteLine("Age pls");
                Age =Convert.ToInt32(Console.ReadLine());

                students.Add(new Student3(Name, Age));
            }

        }
    }
}
