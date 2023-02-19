// using = similar to reuire or import in node
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

        //any method not returning a value must be defined to return void
        static void PrintEmployees(List<Employee> employees)
        {
           for (int i = 0; i < employees.Count; i++)
           {
            string template = "{0, -10}\t{1,-20}\t{2}";
            // String.Format takes template (above) and fills placeholder with values
            // template here takes first arg {0, -10} (id) to be left-aligned and padded 10 characters
            // \t prints tab character
            // {1, -20} next arg is left aligned and padded 20 characters
            // {2} printed with no formatting 
            Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoURL()));
           }
        }

         static void Main(string[] args)
        // main is entry point to application - invoked when program runs and where code placed. must be nested in a class
        //only one entry point to a program
        //void signifies return of this executable method is void
        //static impliues scope is class level, not object level so dont need to create a new class instance
        {
           List<Employee> employees = GetEmployees();
           PrintEmployees(employees);
           
        }
    }
}