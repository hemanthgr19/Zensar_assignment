using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_2_1
{
    class reverse
    {
        public static void Main()
        {
            int n;
            Console.WriteLine("Ente the string: ");
            string s = Console.ReadLine();
            string rev = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--){
                rev += s[i];
            }
            Console.Write("Reverse of the string:");
            Console.Write(rev);

        }
    }
}
