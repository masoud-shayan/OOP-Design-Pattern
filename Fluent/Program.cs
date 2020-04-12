using System;

namespace Fluent
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee();

            employee.NameOfTheEmployee("Masoud")
                .Born("1990/23/08")
                .WorkingOn("IT")
                .StaysAt("Tehran , Iran");
            
            Console.WriteLine(employee.Details);
        }
    }
}
