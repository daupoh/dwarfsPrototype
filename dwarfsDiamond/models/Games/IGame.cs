using dwarfsDiamond.models.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Games
{
    interface IGame:IEntity
    {
        uint PlayersMaxNumbers { get; }
        uint PlayersCurrentNumbers { get; }        
        bool IsEveryOneReady { get; }
        bool IsGameOver { get; }
        
        void playerIsReady(string playerID);
        string playerMakeAction(string playerID, IAction action);
        IList<IAction> getActionsHistoryAfterAction(string actionID);
        string playerAskToRestartGame(string playerID);
        void playerGiveUp(string playerID);
      
    }
}
