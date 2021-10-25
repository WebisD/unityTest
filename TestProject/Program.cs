using System;
using System.Collections.Generic;
using Infrastructure.Transactions;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = new Transactions();

            var objects = transactions.GetNodes().GetAwaiter().GetResult();

            foreach(var item in objects)
            {
                Console.WriteLine(item.ToString());
            }
            /*foreach(var item in objects)
            {
                var propertyInfo = item.GetType().GetProperty("Properties");
                var value = propertyInfo.GetValue(item, null);
                
                foreach(var property in (value as IReadOnlyDictionary<string, object>))
                {
                    Console.WriteLine($"{property.Key} = {property.Value}");
                }

                Console.WriteLine("\n");
            }*/
            
        }
    }
}
