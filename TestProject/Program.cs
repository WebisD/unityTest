using System;
using System.Collections.Generic;
using Infrastructure.Transactions;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = new PlayerTransactions();

            var objects = transactions.GetPlayers().GetAwaiter().GetResult();

            foreach(var item in objects)
            {
                var propertyInfo = item.GetType().GetProperty("Properties");
                var value = propertyInfo.GetValue(item, null);
                
                foreach(var property in (value as IReadOnlyDictionary<string, object>))
                {
                    Console.WriteLine($"{property.Key} = {property.Value}");
                }

                Console.WriteLine("\n");
            }
            
        }
    }
}
