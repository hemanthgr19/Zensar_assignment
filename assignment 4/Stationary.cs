Create a simple Stationery application to add items and display added items using Generic collections
--------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    class Stationary
    {
        static void Main()
        {
            List<string> St = new List<string>();
            Console.Write("Enter the No. of Stationary Elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Stationary Items: ");
            for (int i = 0; i < n; i++)
            {
                St.Add(Console.ReadLine());
            }
            
        }
    }
}

------------------------------------------------------------------------
Output:- 
    Enter the No. of Stationary Elements: 4
Enter The Stationary Items:
Pen
Pencil
Rubber
Scale

C:\Users\HK65862\source\repos\Assignment4\Assignment4\bin\Debug\netcoreapp3.1\Assignment4.exe (process 4800) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .


