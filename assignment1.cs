using System;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("greetings");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"Hello {userName}");
            //Console.WriteLine("Welcome to the world of C#");
            //Console.WriteLine("even or odd");
            //Console.WriteLine("enter the input");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("Given number is even");
            //}
            //else
            //    Console.WriteLine("given number is odd");

            //Console.WriteLine("largest and smallest number");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine($"The largest number is {a}");
            //}
            //else if (b > c && b > a)
            //    Console.WriteLine($"the largest numnber is {b}");
            //else
            //    Console.WriteLine($"the largest number is {c}");


            //if (a < b && a < c)
            //{
            //    Console.WriteLine($"The smallest number is {a}");
            //}
            //else if (b < c && b < a)
            //    Console.WriteLine($"the smallest numnber is {b}");
            //else
            //    Console.WriteLine($"the smallest number is {c}");

            //Console.WriteLine("Marks of five student");
            //int m1 , m2 , m3 , Total;
            //float avg;
            //string name;
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("enter the student name: ");
            //    name = Console.ReadLine();
            //    Console.WriteLine("enter the C# marks: ");
            //    m1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the HTML marks: ");
            //    m2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("enter the SQL marks: ");
            //    m3 = Convert.ToInt32(Console.ReadLine());
            //    Total = m1 + m2 + m3;
            //    Console.WriteLine($"Total marks is :{Total}");
            //    avg = Total / 3.0f;
            //    Console.WriteLine($"The avg of Marks of Student is : {avg}");
            //    if (avg > 50)
            //    {
            //        Console.WriteLine("The student is PASS");
            //    }
            //    else
            //        Console.WriteLine("The student is FAIL");

            //}

            //Console.WriteLine("*********Temperature*********");
            //double  far , con ;
            //Console.WriteLine("Enter the Tempaerature in Fahrenheit :");
            //far = Convert.ToDouble(Console.ReadLine());
            //con = (far - 32) * 5 / 9;
            //Console.WriteLine($"The Celsius {con}");

            Console.WriteLine("*****Array*****");
            //int[] arr = { 20, 30, 40, 50, 60 };
            //int sum = 0;
            //int mx, mn;
            //float avg = 0.0F;
            //sum = arr.Sum();           
            //avg = sum / arr.Length;
            //Console.WriteLine($"The average value of array is {avg}");

            //mx = arr[0];
            //mn = arr[1];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > mx)
            //    {
            //        mx = arr[i];
            //    }
            //    if (arr[i] < mn)
            //    {
            //        mn = arr[i];
            //    }
            //}
            //Console.WriteLine("The minimum value of array " + mn);
            //Console.WriteLine("The maximum value of array " + mx);

            Console.WriteLine("Displaying 10 marks");
            int n, total, min, max, asc, dec;
            int[] arr = new int[11];
            
            double avg;
            Console.WriteLine("Enter the how many subject marks you want:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine("marks - {0} :", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            total = arr.Sum();
            Console.WriteLine("The total marks: {0}", total);
            avg = total / n;
            Console.WriteLine("The average marks: {0}", avg);
            max = arr[0];
            min = arr[1];

            for (int i = 1; i < n + 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("The minimum value of array " + min);
            Console.WriteLine("The maximum value of array " + max);

            Console.WriteLine("The ascending order of array is:");
            Array.Sort(arr);            
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The Descending order is:");
            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}
