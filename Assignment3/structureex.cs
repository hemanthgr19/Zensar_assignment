5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 
-------------------------------------------------------------------------------------

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


OutPut-
    ***** Create a nested structure and store data in an array *****
Enter Total no of employee you want to enter : 2
Name of the employee : Hemanth
Enter day of the birth : 19
Enter month of the birth : 02
Enter year for the birth : 1997

Name of the employee : Shree
Enter day of the birth : 25
Enter month of the birth : 05
Enter year for the birth : 1998


C:\Users\heman\source\repos\BookTrainTicket\BookTrainTicket\bin\Debug\netcoreapp3.1\BookTrainTicket.exe (process 14940) exited with code 0.
Press any key to close this window . . .

