using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> details = new List<Student>() {
                new Student{ ID = 1, name = "Faiq" },
                new Student{ ID = 2, name = "Shafa" },
                new Student{ ID = 3, name = "Turan" },
                new Student{ ID = 4, name = "Adil" },
                new Student { ID = 5, name = "Emil" }

                };


            var newDetails = details.OrderBy(x => x.ID);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.ID + " " + value.name);
            }
        }
        //1 

        //static double DivideNumber(double num1, double num2)
        //{
        //    if (num1 < num2)
        //        num1 += 20;
        //    return num1 / num2;
        //}
        //object obj = null;
        //try
        //{
        //    int i = 20;
        //    int a = 2;

        //    double result = DivideNumber(i / a, i/ 0);
        //}
        //catch (DivideByZeroException ex)
        //{
        //    Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
        //}

        // 2

        //List<int> numbers = new List<int>() {36, 71, 12,
        //                 15, 29, 18, 27, 17, 9, 34};

        //var square = numbers.Max(x => x);
        //Console.Write($"Squares : {square} ");

        // 3


    }
        public class Student
        {

            // properties rollNo and name
            public int ID
            {
                get;
                set;
            }

            public string name
            {
                get;
                set;
            }
        }
}

