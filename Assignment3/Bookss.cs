4. Write a program in C# Sharp to declare a structure called Books with a property, a method to display the value of Book_id, and a private field called Book_id (int)
    --------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrainTicket
{
    // Creating a structire name is Books
    struct Books
    {
        // creating a string variable to give a book name 
        // creating a int variable with name of bookId to declair the book Id no
        public string Name;
        private int BookId;


        //m is int variable it takes the id from the user and it will set to the Book id.
        public int m
        {
            get
            {
                return BookId;
            }
            set
            {
                BookId = value;
            }
        }

        //Displaying the book Id and name.
        public void Display()
        {
            Console.WriteLine($"Book ID is {BookId}.");
            Console.WriteLine($"Book Name is {Name}.");
        }
    }
    class Bookss
    {
        static void Main()
        {
            
            // creating a constructor with name of p by Books
            Books b = new Books();
            //taking the id from the user
            Console.Write("Enter Book No: ");
            //taking the Book name from the user
            b.m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book Name: ");
            b.Name = Console.ReadLine();
            // calling the display method
            b.Display();
            
        }
    }
    
}
------------------------------------------------------------------
    Output:-
        Enter Book No: 009
Enter Book Name: Hemanth
Book ID is 9.
Book Name is Hemanth.

C:\Users\heman\source\repos\BookTrainTicket\BookTrainTicket\bin\Debug\netcoreapp3.1\BookTrainTicket.exe (process 10232) exited with code 0.
Press any key to close this window . . .
