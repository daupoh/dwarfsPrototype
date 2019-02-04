using dwarfsDiamond.models.Player;
using dwarfsDiamond.models.Stown;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.GameMaster
{
    interface IGameMaster
    {
        void startGame();
        void giveUp(IPlayer player);

        IStown getStownFromDekToPlayer(IPlayer player);
        void playerAskAnother(IPlayer asker, IPlayer answerer, string stownsName);
        void endOfRound(IPlayer player);
        
    }
}
