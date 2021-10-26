using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Infrastructure.DbConnection;
using Infrastructure.Transactions.Utils;
using Infrastructure.Transactions.Constants;

namespace Infrastructure.Transactions
{
    public class Transactions : ITransactions
    {
        public async Task<IList<dynamic>> GetNodesAsync()
        {
            List<dynamic> result = null;
            var session = Connection.GetConnection()._driver.AsyncSession();

            try
            {
                result = await session.ReadTransactionAsync(async tx =>
                {
                    var objects = new List<dynamic>();

                    var reader = await tx.RunAsync(QueriesConstants.MatchNodes);

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

        public async Task<string> CreateCharacterAsync()
        {
            var guid = Guid.NewGuid().ToString();
            var session = Connection.GetConnection()._driver.AsyncSession();

            try
            {
                await session.WriteTransactionAsync(async tx =>
                {
                    await tx.RunAsync(
                        query: QueriesConstants.CreateCharacter,
                        parameters: new { Id = guid }
                    );
                });
            }
            finally
            {
                await session.CloseAsync();
            }

            return guid;
        } 
    }
}