using System;
using System.Collections.Generic;
using System.Collections;

namespace _40_FilteringRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<String, String>[] {
                new Dictionary<String, String>() {{"First Name", "John"}, {"Last Name", "Johnson"}, {"Position", "Manager"}, {"Separation date", "2016-12-31"}},
                new Dictionary<String, String>() {{"First Name", "Tou"}, {"Last Name", "Xiong"}, {"Position", "Software Engineer"}, {"Separation date", "2016-10-05" }},
                new Dictionary<String, String>() {{"First Name", "Michaela"}, {"Last Name", "Michaelson"}, {"Position", "District Manager"}, {"Separation date", "2015-12-19" }},
                new Dictionary<String, String>() {{"First Name", "Jake"}, {"Last Name", "Jacobson"}, {"Position", "Programmer"}, {"Separation date", ""}},
                new Dictionary<String, String>() {{"First Name", "Jacquelyn"}, {"Last Name", "Jackson"}, {"Position", "DBA"}, {"Separation date", ""}},
                new Dictionary<String, String>() {{"First Name", "Sally"}, {"Last Name", "Weber"}, {"Position", "Web Developer"}, {"Separation date", "2015-12-18" }},
            };

            Console.Write("Enter a search string:  ");
            string searchString = Console.ReadLine();

            ArrayList containsSearch = new ArrayList();

            foreach (var emp in employees)
            {
                string firstName = emp["First Name"];
                string lastName = emp["Last Name"];

                if (firstName.Contains(searchString) || lastName.Contains(searchString))
                {
                    containsSearch.Add(emp);
                }
            }
            Print(containsSearch);
        }

        static void Print(ArrayList searchResults)
        {
            Console.WriteLine("Results:");
            Console.WriteLine("Name                   | Position               | Separation Date  ");
            Console.WriteLine("______________________________________________________________________");
            foreach (Dictionary<String, String> employee in searchResults)
            {
                var name = employee["First Name"] + " " + employee["Last Name"];
                var position = employee["Position"];
                var date = employee["Separation date"];
                Console.WriteLine("{0, -22} | {1, -22} | {2, -22}", name, position, date);
            }
        }
    }
}
