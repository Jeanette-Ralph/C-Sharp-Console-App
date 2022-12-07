// import correct packages
using System;
using System.IO;
using System.Collections.Generic;

// NOTES // 
// method declared as static: belongs to the class itself, instead of individual instances or objects
// don't have to create a new object to use it 

// namepsace puts all classes under 1 umbrella so they are able to be usede by all classes
namespace CatWorx.BadgeMaker
{
    class Util
    {
        // add list parameter to method
        public static void PrintEmployees(List<Employee> employees)
        {

            for (int i = 0; i < employees.Count; i++)
            {
                // each item in employees is now a new instance of Employee
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        public static void MakeCSV(List<Employee> employees)
        {
            // check to see if data folder exsists
            if (!Directory.Exists("data"))
            {
                // create the database if it does not exist
                Directory.CreateDirectory("data");
            }
        }
    }
}