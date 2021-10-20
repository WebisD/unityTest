using System;
using System.Runtime.InteropServices.ComTypes;

namespace DefaultNamespace
{
    public class Neo4jconnect
    {
        static void Main(string[] args)
        {
            /*var hwe = new HelloWorldExample("bolt://localhost:7687", "Scribo", "1234");
            hwe.PrintGreeting("Hello World");*/
        }
    }

    /*public class HelloWorldExample : IDisposable
    {
        private readonly IDriver _driver;

        public HelloWorldExample(string uri, string userName, string password)
        {
            _driver = GraphDatabase.Driver(uri, AuthTokens.Basic(userName, password));
        }

        public void PrintGreeting(string message)
        {
            using var session = _driver.Session();
            var greeting = session.WriteTransaction( tx =>
            {
                var result = tx.Run("CREATE (a:Greeting) " +
                                    "SET a.message = $message " +
                                    "RETURN a.message + ', from node ' + id(a)",
                    new {message});
                return result.Single()[0].As<string>;
            });
            Console.WriteLine(greeting);
        }

        public void Dispose()
        {
            _driver.Dispose();
        }
    }*/
}