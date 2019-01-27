using dwarfsDiamond.models.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Client_Server
{
    class CClient: IGameMaster
    {
        string createNewPlayer();//return global player ID
        void changeName(string oldName, string newName, string PlayerID); //change playerID player name

        string createLocalRoom(string playerID, uint nPlayers); //create local room for nPlayers numbers and return Room ID
        string createRoom(string playerID, uint nPlayers);
        string enterRoom(string playerID, string roomID); //enter player with global PlayerID into room with RoomID and return GameID
        IList<string> enterLocalRoom(string playerID, string roomID);//enter localroom and get list of localIDs

        string readyToStartGame(string playerID, string roomID); //return 'wait' or gameID        
        string makeAction(string playerID, string roomID, string gameID, IAction action); //make action by playerID in roomID 
                                                                                          //game and return last action actionId
        IList<IAction> rebuildField(string playerID, string roomID, string gameID, string actionID);//return list of action after action with actionID, 
                                                                                                    //rewrite last acionID
        IList<string> isAnyOneLeftGame(string playerID, string roomID, string gameID); //return NAMES of lefted players
        string isGameOver(string playerID, string roomID, string gameID); //return 'No' or winner NAME

        void giveUp(string playerID, string roomID, string gameID);
        string askToRestartGame(string playerID, string gameID, string roomID); //game with GameID in room with RoomID over and return new game GameID, or "No"
        void leaveRoom(string playerID, string roomID); //leave room with RoomID
    }
}
