using System;
using System.Linq;

namespace Q_29
{
    class account
    {
        int account_no;
        string name;

        internal void getCData()
        {
            Console.Write("Enter Account no: ");
            account_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Account holder name: ");
            name = Console.ReadLine();
            Console.WriteLine();
        }
    }
    class saving_account : account
    {
        int num, awailable_balance, witnhdraw_amount;
        int total_bal = 200000;  
        double SI, P, R, N;

        internal void Saving_ser()

        {
            getCData();
            Console.WriteLine("Press 1 for Simple Interest");
            Console.WriteLine("Press 2 for withdraw");
            Console.WriteLine("Press 3 for Cheque book");
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (num)
            {
                case 1:
                    Console.Write("Enter principle value: ");
                    P = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter rate of interest: ");
                    R = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter no of years: ");
                    N = Convert.ToDouble(Console.ReadLine());

                    SI = P * R * N / 100;
                    Console.Write("The simple interest is: " + SI);
                    break;

                case 2:
                    Console.WriteLine("Total balance is: " + total_bal);
                    Console.Write("Enter amount to be withdrawn: ");
                    witnhdraw_amount = Convert.ToInt32(Console.ReadLine());

                    awailable_balance = total_bal - witnhdraw_amount;

                    total_bal = awailable_balance;
                    Console.WriteLine("Available balance is: " + total_bal);
                    break;

                case 3:
                    Console.WriteLine("For cheque book service please open Current acocunt.");
                    break;

                default:
                    Console.WriteLine("Sorry! you havent choose any service.");
                    break;

            }
        }
    }
    class current_account : account
    {
        int num, withdraw_amount, available_bal;
        int total_bal = 10000;
        int min_bal = 2000;
        int chequeBook = 200;
        internal void Current_ser()
        {
            getCData();
            Console.WriteLine("Press 1 for withdraw");
            Console.WriteLine("Press 2 for Cheque book");
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Total balance is: " + total_bal);
                    Console.WriteLine("If after withdrawal account balance less than minimum balance then need to pay penalty Rs.200");
                    Console.Write("Enter amount to be withdraw: ");
                    withdraw_amount = Convert.ToInt32(Console.ReadLine());
                    if (withdraw_amount < total_bal)
                    {
                        available_bal = total_bal - withdraw_amount;
                        if (available_bal < min_bal)
                        {
                            Console.WriteLine("Account balance less than minimum amount, So need to pay standard penalty Rs.200.");
                            available_bal = total_bal - 200;
                            Console.WriteLine("Penalty deducted and Available balance is: " + available_bal);
                        }
                        else
                        {
                            total_bal = available_bal;
                            Console.WriteLine("Available balance is: " + total_bal);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry! you don't have required balance in account.");
                    }
                    break;

                case 2:
                    available_bal = total_bal - chequeBook;
                    Console.WriteLine("Available balance is: " + available_bal);
                    Console.WriteLine("Cheque book issued on: " + DateTime.Now);
                    break;
            }
        }
    }
    class bank
    {
        static void Main(string[] args)
        {
            saving_account sa = new saving_account();
            current_account ca = new current_account();
            string account_type;

            Console.WriteLine("Enter saving for Saving account services");
            Console.WriteLine("Enter current for Current account services");
            Console.Write("Enter type of account(press 1 For Saving Account / Press 2 For Current Account) : ");
            account_type = Console.ReadLine();

            switch (account_type)
            {
                case "1":
                    sa.Saving_ser();
                    break;

                case "2":
                    ca.Current_ser();
                    break;

                default:
                    Console.WriteLine("You haven't selected any service, Please press any number.");
                    break;
            }
            Console.Read();
        }
    }
}
