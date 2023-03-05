// Import correct packages
using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    // Add List parameter to method
    // method declared as static
    //any method not returning a value must be defined to return void
    public static void PrintEmployees(List<Employee> employees) 
    {
      for (int i = 0; i < employees.Count; i++) 
      {
        // String.Format takes template (above) and fills placeholder with values
            // template here takes first arg {0, -10} (id) to be left-aligned and padded 10 characters
            // \t prints tab character
            // {1, -20} next arg is left aligned and padded 20 characters
            // {2} printed with no formatting 
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
      }
    }

    // add method to utl to make CSV
    // call this within program
    // check whether data folder exists, if not create
    // file located at data/employees.csv
    // loop over employees
    // write info to csv file
    public static void MakeCSV(List<Employee> employees)
    {
        if (!Directory.Exists("data"))
        {
            Directory.CreateDirectory("data");
        }

        using (StreamWriter file = new StreamWriter("data/employees.csv"))
        {
            file.WriteLine("ID,Name,PhotoUrl");

            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0},{1},{2}";
                file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }

        // read file back once finished writing to it
        try 
        {
            using (StreamReader sr = new StreamReader("data/employees.csv"))
                {
                    string line;
                    while ((line=sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read");
            Console.WriteLine(e.Message);
        }
    }
  }
}