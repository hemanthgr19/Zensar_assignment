using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignmentv2_2
{

    class Student
    {
        public int RollNo, sum;
        public string Name, Class, Sem, branch, res;
        public double avg;
        

       
        public void Display()
        {
            Console.WriteLine("student RollNo is : {0} ", RollNo);
            Console.WriteLine("Student Name is: {0}", Name);
            Console.WriteLine("Student Class is: {0}", Class);
            Console.WriteLine("Student Semister is: {0}", Sem);
            Console.WriteLine("Student Branch is :  {0} ", branch);
            //Console.WriteLine("Student Result is: {0}", res);



        }
    }

    class Programs : Student
    {
        public static void Main(string[] args)
        {
            string res ;

            Student s1 = new Student();
            Console.Write("Enter the RollNo:  ");
            s1.RollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Studnet Name: ");
            s1.Name = Console.ReadLine();
            Console.Write("Enter the class: ");
            s1.Class = Console.ReadLine();
            Console.Write("Enter the sem: ");
            s1.Sem = Console.ReadLine();
            Console.Write("enter the branch");
            s1.branch = Console.ReadLine();
            Console.WriteLine("Enter the Marks:");
            int[] marks = new int[5];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }


            s1.sum = marks.Sum();
            Console.WriteLine("Total marks :{0} ", s1.sum);

            s1.avg = marks.Average();
            Console.WriteLine("average is : {0}", s1.avg);

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] >= 35)
                {
                    if (marks[i] > 35 && s1.avg > 50)
                    {
                        Console.WriteLine("Your Passed in Marks and average");
                        i = 10;
                        res = "pass";
                        
                     }
                    else
                    {
                        Console.WriteLine("your failed by average ");
                        res = "Fail";
                    }
                        


                }
                else
                {
                    Console.WriteLine("Your Failed in marks");
                    i = 20;
                    res = "Fail";
                }

            }
            s1.Display();
        }

        
    }
}
