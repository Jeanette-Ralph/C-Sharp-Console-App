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
            List<string> employees = new List<string>();

            // collect user values until the value is an empty string

            while (true)
            {
                Console.WriteLine("Please enter a namee:");

                // get a name from the console and assign it to a variable
                string input = Console.ReadLine() ?? "";

                // break out of loop if user doesnt enter a name
                if (input == "")
                {
                    break;
                }
                employees.Add(input);

            }
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }

        }
    }
}
