using System;
using Neo4j.Driver;

namespace Infrastructure.DbConnection
{
    public class Connection : IDisposable
    {

        public readonly IDriver _driver;

        private static Connection _connection { get; set; }

        private Connection(){
            _driver = GraphDatabase.Driver(
                "neo4j+s://a0aa1dbc.databases.neo4j.io", 
                AuthTokens.Basic("neo4j", "2hYk9gOHAPUVZwVZNsnnghrMt_XtTAXYeVbpy8lJh_c")
            );

            _driver.VerifyConnectivityAsync().Wait();
        }

        public static Connection GetConnection() => 
            _connection ?? (_connection = new Connection());


        public void Dispose() => _driver.Dispose();
        
    }
}