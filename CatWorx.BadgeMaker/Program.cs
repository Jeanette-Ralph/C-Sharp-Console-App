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
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }

        static List<Employee> GetEmployees()
        {

            List<Employee> employees = new List<Employee>();
            // collect user values until the value is an empty string

            while (true)
            {
                Console.WriteLine("Please enter a name: ");

                // Move the initial prompt inside the loop, so it repeats for each employee
                Console.WriteLine("Enter first name (leave empty to exit): ");

                // change input to firstName
                string firstName = Console.ReadLine() ?? "";

                // break out of loop if user doesnt enter a name
                if (firstName == "")
                {
                    break;
                }

                // add a Console.ReadLine() for each value
                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";

                Console.Write("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");

                Console.Write("Enter Photo URL:");
                string photoUrl = Console.ReadLine() ?? "";

                Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(currentEmployee);

            }

            return employees;
        }


    }

}
