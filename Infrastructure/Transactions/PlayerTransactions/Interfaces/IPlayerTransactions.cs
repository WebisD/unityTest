using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Transactions.Player
{
    public interface IPlayerTransactions
    {
        Task<dynamic> GetPlayers();
        
    }
}