Create a console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets)
that takes no.of tickets to be booked. If the no of tickets is > 5 per booking,raise an user defined exception, and print "cannot book more than 2 tickets".
Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
____________________________________________

using System;

namespace BookTrainTicket
{
     class TicketBooking : ApplicationException
     {
        public TicketBooking(string msg) : base(msg)
        {

        }


    }

     class Passenger
     {
        public string Name;
        public int age;

        public void GetData()
        {
            Console.Write("Enter Passenger Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Passenger Age:");
            age = Convert.ToInt32(Console.ReadLine());
        }

        public void TicketBooking(int NO_of_Ticket)
        {
            
            if (NO_of_Ticket < 5)
            {
                
                throw (new TicketBooking("Ticket Booking succesfully"));
            }
            else
                Console.WriteLine("Cannot Book More then 2 Tickets");
        }




     }
     class Test
     {
        static void Main(string[] args)
        {
            Passenger P = new Passenger();
            //P.Name = Console.ReadLine();    
            //P.age = Convert.ToInt32(Console.ReadLine());    
            P.GetData();
            Console.Write("Enter no of Tickets you Want to Book: ");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                P.TicketBooking(n);
            }
            catch (TicketBooking Pe)
            {
                Console.WriteLine(Pe.Message + " " + Pe.Source);
            }
            
        }
     }



}

Output=
Enter Passenger Name: Hemanth
Enter Passenger Age:24
Enter no of Tickets you Want to Book: 3
Ticket Booking succesfully BookTrainTicket

C:\Users\heman\source\repos\BookTrainTicket\BookTrainTicket\bin\Debug\netcoreapp3.1\BookTrainTicket.exe (process 6096) exited with code 0.
Press any key to close this window .
