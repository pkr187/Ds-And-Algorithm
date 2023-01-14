using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DsAndAlgorithm
{
    internal class BankingCashCounter
    {
        public void ATM()
        {
            Console.WriteLine("Enter Bank Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            LinkedListQueue<string> queue = new LinkedListQueue<string>();
            Console.WriteLine("Enter Length of the Queue");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                string name = Console.ReadLine();
                queue.Enqueue(name);
            }
            while (length > 0)
            {
                Console.WriteLine("Choose an option" + "\n" + "1.Deposit" + "\n" + "2.Withdraw");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to Deposit: ");
                        int deposite = Convert.ToInt32(Console.ReadLine());
                        amount += deposite;
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to Withdraw: ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > amount)
                        {
                            Console.WriteLine("Insufficient Funds");
                        }
                        else
                            amount -= withdraw;
                        break;

                    default:
                        Console.WriteLine("Please Choose Approprite Aoption");
                        break;
                }
                queue.Dequeue();
                length--;
            }
            queue.Display();
        }
    }
}
    

