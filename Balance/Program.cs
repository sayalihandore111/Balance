using System;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int balance = 10000, withdrawl;
            Console.Write("Enter Withdwawl amount: ");
            withdrawl = Convert.ToInt32(Console.ReadLine());
            balance = withdrawl > balance ? balance : balance - withdrawl;
            Console.WriteLine("Balance=" + balance);
        }
    }
}
