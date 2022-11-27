// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

// namespace provides separation in the code
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // static --> means scope is at the class level
        static void Main(string[] args) // entry point
        {
            List<string> employees = new List<string>() { "adam", "amy" };

            employees.Add("barbara");
            employees.Add("billy");
            Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }
}
