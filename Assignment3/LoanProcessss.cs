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
