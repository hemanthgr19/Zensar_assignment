using System;
using System.Collections.Generic;
using System.Text;

namespace structuress
{
    class structureex
    {
        //employee is a structure of members eName and DOB
        struct employee
        {
            public string eName;
            public DOB Date;
        }
        //DOB is a nested structure of employee
        struct DOB
        {
            public int Date;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {

            int d, m, y;
            
            Console.WriteLine("Create a nested structure and store data in an array :");
            Console.WriteLine("Enter Total no of employee you want to enter");
            int t = Convert.ToInt32(Console.ReadLine());
            employee[] emp = new employee[t];
            // creating a for loop for initializing the data of name and dob in structure
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;

                Console.Write("Enter day of the birth : ");
                d = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Date = d;

                Console.Write("Enter month of the birth : ");
                m = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = m;

                Console.Write("Enter year for the birth : ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = y;
            }
        }



    }
}
