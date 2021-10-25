using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Infrastructure.Models;

namespace Infrastructure.Transactions.Utils
{
    public class TransactionUtils
    {
        public static Character GetCharacterFromResult(JObject queryResult)
        {
            var characterProperties = queryResult["Properties"].ToString();
            var mappedCharacter = JsonConvert.DeserializeObject<Character>(characterProperties);

            return mappedCharacter;
        }

    }
}