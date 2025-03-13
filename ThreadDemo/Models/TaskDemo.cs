using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo.Models
{
   public class TaskDemo
    {
        private static decimal balance = 10000;


        public async Task Entry()
        {
            Task<decimal>[] tasks = new Task<decimal>[3];
            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = WithdrawMoneyAsync(new Random().Next(1000, 10000), new Random().Next(1000, 5000));
                
            }

            decimal[] balances = await Task.WhenAll(tasks);
            Console.WriteLine("Banking System Closed....");
            balances.ToList().ForEach(b => Console.WriteLine($"Final Balance {b}"));
        }

        public async Task<decimal> WithdrawMoneyAsync(long customerId, decimal amount)
        {
            Console.WriteLine($"Available balance {balance} for Customer {customerId}");
            await Task.Delay(new Random().Next(1000, 5000));
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Amount {amount} withdrawn successfully for Customer {customerId}");
                return balance;
            }
            else
            {
                Console.WriteLine($"Insufficient balance for Customer {customerId}");
                return balance;
            }

        }
    }
}
