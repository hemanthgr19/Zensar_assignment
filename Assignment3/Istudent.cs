using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrainTicket
{
    class Istudent
    {
        interface IStudent
        {
            public void ShowDetails(int StudentId , string Name);
            //public void ShowDetails(string Name);
        }

        class Dayscholar : IStudent
        {
            //public void ShowDetails(String Name)
            //{
            //    Console.WriteLine($"{Name} is DayScholar student....");
            //}

            //public void showDetails(int studnetID)
            //{
            //    Console.WriteLine($"{studnetID} is a student id ");
            //}

            public void ShowDetails(int StudentId , string Name)
            {
                //Console.WriteLine($"{StudentId} is a student id ");
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }

            //public void ShowDetails(string Name)
            //{
            //    Console.WriteLine($"{Name} is DayScholar student....");
            //}
        }

        class Resident : IStudent
        {
            public void ShowDetails(int StudentId , string Name)
            {
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }
            //public void ShowDetails(string Name)
            //{
            //    Console.WriteLine($"{Name} is Resident Student....");
            //}

            
        }
        class Program
        {
            static void Main(string[] args)
            {
                Dayscholar D1 = new Dayscholar();
                D1.ShowDetails(019, "Hemanth");
                Dayscholar D2 = new Dayscholar();
                D2.ShowDetails(025, "Shree");

                Resident D3 = new Resident();
                D3.ShowDetails(028, "Geetha");
                Resident D4 = new Resident();
                D3.ShowDetails(018, "niki");
                
                
            }
        }
    }
}
