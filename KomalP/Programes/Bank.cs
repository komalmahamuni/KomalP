using System;
using System.Collections.Generic;
using System.Text;

namespace KomalP.Programes
{
    class Bank
    {
        int Acc_no;
        string Cust_nm;
        int bal;

        public void Bank_dtl(int Acc_no,string Cust_nm,int bal)
        {
            this.Acc_no = Acc_no;
            this.Cust_nm = Cust_nm;
            this.bal = bal;
        }
        public void BankDtl_Display()
        {
            Console.WriteLine("Account Number:" + Acc_no);
            Console.WriteLine("Customer Name:" + Cust_nm);
            Console.WriteLine("Customer Balance:" + bal);
        }
       public void Money_Widraw()
        {
            Console.WriteLine("Enter withdraw Amount");
            int n = int.Parse(Console.ReadLine());
            if (bal > n)
            {
                Console.WriteLine("Withdraw the amount in urrent Balance:");
                int widraw_bal = bal - n;
                Console.WriteLine("Withdraw Balance:" + widraw_bal);

            }
            else
                Console.WriteLine("Error...");
        }
        public void Deposit_Amount()
        {
            Console.WriteLine("Deposit Amount in current balance:");
            int d = int.Parse(Console.ReadLine());
            int curr_bal = bal + d;
            Console.WriteLine("current Balance:" + curr_bal);
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.Bank_dtl(1006, "Priti", 15000);
            b.BankDtl_Display();
                b.Money_Widraw();
            b.Deposit_Amount();
        }
    }
}
