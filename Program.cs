// using = similar to reuire or import in node
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
// namespace organise and provide level of separation in code. Containers that have members which can be a nested namespace, method or class
{
    class Program
    {
        static void Main(string[] args)
        // main is entry point to application - invoked when program runs and where code placed. must be nested in a class
        //only one entry point to a program
        //void signifies return of this executable method is void
        //static impliues scope is class level, not object level so dont need to create a new class instance
        {
           List<string> employees = new List<string>(){"adam", "amy"};

           employees.Add("barbara");
           employees.Add("billy");

           employees.ForEach(i => Console.WriteLine(i));
           
        }
    }
}