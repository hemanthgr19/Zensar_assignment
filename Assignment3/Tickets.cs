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
