using System;
using System.Reflection;
using Infrastructure.DbConnection;
using Infrastructure.Transactions;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var conn = Connection.GetConnection();
            var transactions = new PlayerTransactions();

            var x = transactions.GetPlayers().GetAwaiter().GetResult();


            Console.WriteLine(x.Count);
            
        }
    }
}
