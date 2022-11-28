// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

// namespace provides separation in the code
namespace CatWorx.BadgeMaker
{
    class Program
    {
        // static --> means scope is at the class level, static method can only call another static method
        static void Main(string[] args) // entry point
        {
            // getting employees
            List<string> employees = GetEmployees();

        }

        static List<string> GetEmployees()
        {

            List<string> employees = new List<string>();
            // collect user values until the value is an empty string

            while (true)
            {
                Console.WriteLine("Please enter a name: ");

                // get a name from the console and assign it to a variable
                string input = Console.ReadLine() ?? "";

                // break out of loop if user doesnt enter a name
                if (input == "")
                {
                    break;
                }

                // create a new instance of employee
                Employee currentEmployee = new Employee(input, "Smith");
                employees.Add(currentEmployee.GetFullName());

            }

            return employees;
        }

        // if not returning anything then it must have a "void" return type
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
    }

}
