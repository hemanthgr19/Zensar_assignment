3.Create an Interface IStudent with StudentId and Name as Properties, ShowDetails() as its method. Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods. Test The functionalities.

----------------------------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace IstudentRD
{
    class Istudent
    {
        interface IStudent
        {

            // iam Creating property with studnet name and id.
            public void ShowDetails(int StudentId , string Name);
            
        }

        class Dayscholar : IStudent
        {
            
            // in dayscholar iam displaying the details of student . the student is Dayscholar 
            public void ShowDetails(int StudentId , string Name)
            {
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }

            
        }

        class Resident : IStudent
        {
            // in Resident iam displaying the details of student . the student is Dayscholar
            public void ShowDetails(int StudentId , string Name)
            {
                Console.WriteLine($"{Name} is a Student and The ID is {StudentId}. The student is a Residental student.");
            }
            

            
        }
        class Program
        {
            static void Main(string[] args)
            {
                // sending the student name id and name to method of Daysscholr. 
                Dayscholar D1 = new Dayscholar();
                D1.ShowDetails(019, "Hemanth");
                Dayscholar D2 = new Dayscholar();
                D2.ShowDetails(025, "Shree");
                // sending the student name id and name to method of Resident.
                Resident D3 = new Resident();
                D3.ShowDetails(028, "Geetha");
                Resident D4 = new Resident();
                D3.ShowDetails(018, "niki");
                
                
            }
        }
    }
}

--------------------------------------------------------------------------------------------
    Output:- 
Hemanth is a Student and The ID is 19. The student is a Residental student.
Shree is a Student and The ID is 25. The student is a Residental student.
Geetha is a Student and The ID is 28. The student is a Residental student.
niki is a Student and The ID is 18. The student is a Residental student.

C:\Users\heman\source\repos\BookTrainTicket\BookTrainTicket\bin\Debug\netcoreapp3.1\BookTrainTicket.exe (process 19176) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .

