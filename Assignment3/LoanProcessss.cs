
Create a console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets)
that takes no.of tickets to be booked. If the no of tickets is > 5 per booking,raise an user defined exception, and print "cannot book more than 2 tickets".
Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.
____________________________________________


using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrainTicket
{
    class BalanceException : ApplicationException
    {
        public BalanceException(string msg) : base(msg)
        {

        }
    }
    class LoanProcessss
    {
        public int Loan_no;
        public string Customer_Name;
        public double Loan_amount;
        public double Emi_amount;
        public double Account_balance;
        public double r;
        public int y;

        public LoanProcessss(long loanNo, string name)
        {
            Loan_no = (int)loanNo;
            Customer_Name = name;
        }
        public double calculate_EMI()
        {
            r = 13/100;
            y = 36;
            Loan_amount = 500000;
            
            Emi_amount = (Loan_amount * Math.Pow((r / 12) + 1, (y)) * r / 12) / (Math.Pow((r / 12) + 1, (y)) - 1);
            return (Emi_amount);

        }

        public void check_balance()
        {
            Console.Write("Enter Account Balance:  ");
            Account_balance = Convert.ToDouble(Console.ReadLine());
            if(Account_balance < Emi_amount)
            {
                throw (new BalanceException("You dont have sufficient balance in your to clear your EMI amount"));
            }
            else
            {
                Console.WriteLine("EMI amount id debeted from your account");
            }
        }

        
    }

    class Loan
    {
        public void Main(string[] args)
        {
            LoanProcessss Lp = new LoanProcessss(123456789, "Hemanth");
            Lp.calculate_EMI();
            try
            {
                Lp.check_balance();

            }
            catch (BalanceException be)
            {
                Console.WriteLine(be.Message);
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
    
