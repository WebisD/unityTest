using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Transactions.Player
{
    public interface IPlayerTransactions
    {
        Task<IList<object>> GetPlayers();

        //Task SavePlayer();
        
    }
}