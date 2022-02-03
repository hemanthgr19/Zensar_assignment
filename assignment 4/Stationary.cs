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
