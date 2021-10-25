using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.DbConnection;
using Infrastructure.Transactions.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Infrastructure.Transactions
{
    public class Transactions : ITransactions
    {
        public async Task<IList<dynamic>> GetNodes()
        {
            List<dynamic> result = null;
            var session = Connection.GetConnection()._driver.AsyncSession();

            try
            {
                result = await session.ReadTransactionAsync(async tx =>
                {
                    var objects = new List<dynamic>();

                    var reader = await tx.RunAsync("MATCH (n)-[r]->(m) RETURN n,r,m");

                    while (await reader.FetchAsync())
                    {
                        var characterJson = 
                            JObject.Parse(JsonConvert.SerializeObject(reader.Current[0]));

                        var character = TransactionUtils.GetCharacterFromResult(characterJson);

                        objects.Add(character);

                    }
                    
                    return objects;
                });
            }
            finally
            {
                await session.CloseAsync();
            }

            return result;
        }

    }
}