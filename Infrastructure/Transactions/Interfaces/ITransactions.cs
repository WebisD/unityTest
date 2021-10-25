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

        Task<IList<dynamic>> GetNodes();

        //Task SaveNodes(EnumVilaoJogadorItem enum);

        //Task DeleteNodes(int nodeId)

        //Task ConnectNodes(int firstNode, int secondNode)
    }
}