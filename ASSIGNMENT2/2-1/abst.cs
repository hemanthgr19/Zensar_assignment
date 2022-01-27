using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace assignmentv2_2
{
    abstract class Studentabs
    {
        public string Name = "Hemanth";
        public int StudentId = 019;
        
        public abstract Boolean Ispassed(float grade);
        
    }

    class UGraduate : Studentabs
    {
        
        public override bool Ispassed(float grade)
        {
            Console.Write("UnderGraduate:  ");
            if (grade > 70.0f )
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

       
    }

    class Graduate : Studentabs
    {
        public override bool Ispassed(float grade)
        {
            Console.Write("Graduate:  ");
            if (grade > 80.0f)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    class Abstr
    {
        public static void Main(string[] args)
        {
            bool pass;
            UGraduate u = new UGraduate();
            Console.WriteLine("Student Name is: "+ u.Name);
            Console.WriteLine("Student Idno is: "+ u.StudentId);
            pass = u.Ispassed(80.0f);
            if (pass)
            {
                Console.WriteLine("The Student is passed in UnderGraduate");
            }
            else
                Console.WriteLine("The Student is Failed in UnderGraduate");

            Graduate g = new Graduate();
            pass = g.Ispassed(71.0f);
            if (pass)
            {
                Console.WriteLine("The Student is passed in Graduate");
            }
            else
                Console.WriteLine("The Student is Failed in Graduate");

        }
        


    }
        
    
}
