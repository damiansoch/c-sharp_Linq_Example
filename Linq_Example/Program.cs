using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //specify data source
            string[] students = new string[] { "Adam", "Joshua", "Adrian", "Gregory", "Anna", "Adrian", "Derek", "Damian", "Simon", "Eustachy", "Alex", };

            //define the query expression
            IEnumerable<string> Names = 
                from student in students
                where student.Length>=6
                select student;

            //Execute the query
            foreach (string name in Names)
            {
                Console.Write(name + " ");

            }

            Console.ReadLine();
        }
    }
}
