using System;


namespace assignmentv2_2
{
    class Account
    {
        public int t;

        public string CustomerName, AccountType;
        public double AccountNo, amount, w, d, sum , Prod ;

        public void AccountSummery()
        {
            Console.WriteLine("Account Holder Name is {0}", CustomerName);
            Console.WriteLine(" Account Number is :{0}", AccountNo);
            Console.WriteLine("Account type is :{0}",AccountType);
            Console.WriteLine("Account Balance is :{0}",amount);
        }
        
        public void credit()
        {
            Console.WriteLine(amount);
            Console.Write("Please enter an amount to deposite:  ");
            d = Convert.ToDouble(Console.ReadLine());
            amount = d + amount;            
            Console.WriteLine("your account Balance is : {0}", amount);

        }

        public void debit()
        {
            Console.WriteLine("Enter the amount You want to withdraw : ");
            w = Convert.ToDouble(Console.ReadLine());   
            amount = amount - w;
            Console.WriteLine("your account Balance is : {0}", amount);
            
        }

    }
    class Program: Account
    {
        
        static void Main(string[] args)
        {
            int t =0;
            Console.WriteLine("*****Your Acoount*****");
            Console.WriteLine("Please select the optiion");
            Account account = new Account();
            account.CustomerName = "Hemanth";
            account.AccountType = "savings";
            account.AccountNo = 123456789;
            account.amount = 50000.00;
            Console.WriteLine("1. Account Details ");
            Console.WriteLine("2. Transactions type ");
            Console.WriteLine("3. Balance ");
            Console.WriteLine("4. Exit ");
            Console.WriteLine(" ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 1)
            {
                account.AccountSummery();
                Console.WriteLine();
            }
            else if (n == 2)
            {
                Console.WriteLine("Select The Transaction: ");
                Console.WriteLine(" ");
                Console.Write("1.Deposite ");
                Console.WriteLine("  2. Withdrawl");
                t = Convert.ToInt32(Console.ReadLine());
                if (t == 1)
                {
                    account.credit();
                }
                else if (t == 2)
                {
                    account.debit();
                }

                else
                    Console.WriteLine("YOUR TRANSACTION WAS CANCELLED YOU ENTERED INVALID NUMBER");
            }




        }
    }
}
