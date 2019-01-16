using System;
using System.Collections;

namespace _34_EmployeeListRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList employees = new ArrayList();
            employees.Add("John Smith");
            employees.Add("Jackie Jackson");
            employees.Add("Chris Jones");
            employees.Add("Amanda Cullen");
            employees.Add("Jeremy Goodwin");

            Print(employees);

            Console.Write("\nEnter an employee name to remove:  ");
            string removeEmployee = Console.ReadLine();

            if (employees.Contains(removeEmployee))
            {
                employees.Remove(removeEmployee);
            }
            else
            {
                Console.WriteLine("Employee with this name does not exist.");
            }

            Print(employees);

        }

        static void Print(ArrayList employees)
        {
            Console.WriteLine("\nThere are {0} employees:", employees.Count);
            foreach (string person in employees)
            {
                Console.WriteLine("{0}", person);
            }
        }

    }
}

