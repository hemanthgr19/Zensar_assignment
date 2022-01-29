
CWrite a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount, Account_Balance as its members. Create a method calculate_EMI() 
for the LoanAmount , with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount. The rest of the information to be passed 
through constructors. Write another function CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. If yes then throw a 
custom exception. Display " Not Sufficient Balance to repay Loan" in the finally. Give explanatory comments. 

____________________________________________


namespace Loans

{
    class BalanceException : ApplicationException
    {
        public BalanceException(string msg) : base(msg)
        {

        }
    }
    class LoanProcessss
    {
        
        // initilizing the variables.
        public int Loan_no;
        public string Customer_Name;
        public double Loan_amount;
        public double emi;
        public double Account_balance;
        
        
        public LoanProcessss(long loanNo, string name)
        {
            Loan_no = (int)loanNo;
            Customer_Name = name;
            
        }
        

        public void calculate_EMI()
        {
            Console.WriteLine("Enter loan amount");
            Loan_amount =Convert.ToDouble(Console.ReadLine());
            // Emi Formula
            emi = Loan_amount * 0.13 * 3;

            
        }

        public void check_balance()
        {
            // Checking the account Balance
            Console.Write("Enter Account Balance:  ");
            Account_balance = Convert.ToDouble(Console.ReadLine());
            if(Account_balance < emi)
            {
                throw (new BalanceException("You dont have sufficient balance in your to clear your EMI amount"));
            }
            else
            {
                Console.WriteLine("EMI amount is debeted from your account");
            }
        }

        
    }

    class Loan
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***Loan Process***");
            // Giving input to The Loan process method account number and name..
            LoanProcessss Lp = new LoanProcessss(123456789, "Hemanth");
            Console.WriteLine("Loan Holder is: "+ Lp.Customer_Name);
            Console.WriteLine("Loan Holder Loan Number is: " + Lp.Loan_no);
            //calling the calculating the emi..
            Lp.calculate_EMI();
            try
            {
                //checking the balance 
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
 ***Loan Process***
Loan Holder is: Hemanth
Loan Holder Loan Number is: 123456789
Enter loan amount
5000
Enter Account Balance:  25000
EMI amount is debeted from your account

C:\Users\heman\source\repos\BookTrainTicket\BookTrainTicket\bin\Debug\netcoreapp3.1\BookTrainTicket.exe (process 21348) exited with code 0.
Press any key to close this window . . .

