using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.DbConnection;
using Infrastructure.Transactions.Player;

namespace Infrastructure.Transactions
{
    public class PlayerTransactions : IPlayerTransactions
    {

        public async Task<IList<object>> GetPlayers()
        {
            List<object> result = null;

            using (var session = Connection.GetConnection()._driver.AsyncSession())
            {
                result = await session.ReadTransactionAsync(async tx =>
                {
                    var objects = new List<object>();

                    var reader = await tx.RunAsync("MATCH (n)-[r]->(m) RETURN n,r,m");

                    while (await reader.FetchAsync())
                    {
                       objects.Add(reader.Current[0]);
                    }

                    return objects;
                });
            }

            return result;
        }

    }
}