using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_2_1
{
    class checkwords
    {
      
        public static void Main()
        {
            Console.WriteLine("Enter the string one: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the string Secound: ");
            string str2 = Console.ReadLine();

            if (str1 == str2)
            {
                Console.WriteLine("words are same");

            }
            else
                Console.WriteLine("words are not same");

        }
    }
}
