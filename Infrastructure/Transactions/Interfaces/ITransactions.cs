using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Transactions
{
    public interface ITransactions
    {
        /*
            -> uma query para criar um personagem
            -> uma query para criar npc
            -> uma query para ligar personagem e npc 
            -> uma query para ligar personagem e item
        */

        Task<IList<dynamic>> GetNodesAsync();

        //Task SaveNodesAsync(EnumVilaoJogadorItem enum);

        //Task DeleteNodeAsync(int nodeId)

        //Task ConnectNodesAsync(int firstNode, int secondNode)
    }
}