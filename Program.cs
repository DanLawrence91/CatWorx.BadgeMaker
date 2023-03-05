// using = similar to require or import in node
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
// namespace organise and provide level of separation in code. Containers that have members which can be a nested namespace, method or class
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
            Console.WriteLine("Please enter first name (leave empty to exit): ");
            string firstName = Console.ReadLine() ?? "";
            if (firstName == "")
            {
                break;
            }
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine() ?? "";
            Console.WriteLine("Enter Id: ");
            int id = Int32.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Enter Photo URL: ");
            string photoUrl = Console.ReadLine() ?? "";
            // ?? is null coalescing operator as input variable can only be string and not null, if input is null will use value after operator
            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            employees.Add(currentEmployee);
           }
           return employees;
        }

        static void Main(string[] args)
        // main is entry point to application - invoked when program runs and where code placed. must be nested in a class
        //only one entry point to a program
        //void signifies return of this executable method is void
        //static impliues scope is class level, not object level so dont need to create a new class instance
        {
           List<Employee> employees = GetEmployees();
           Util.PrintEmployees(employees);
           Util.MakeCSV(employees);
        }
    }
}