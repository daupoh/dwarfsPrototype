using dwarfsDiamond.models.Actions;
using dwarfsDiamond.models.Entities;
using dwarfsDiamond.models.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Client_Server
{
    class CClient: ACEntity,IGameMaster
    {
        IGameMaster m_pLocalServer;

        public CClient(IGameMaster localServer)
        {
            m_pLocalServer = localServer;
        }       
        public string createNewPlayer(string name)//return global player ID
        {            
            string nameAndId = m_pLocalServer.createNewPlayer(name),
            justName = nameAndId.Substring(0, nameAndId.IndexOf('/'));

            return justName;

        }
        public void changeName(string oldName, string newName, string PlayerID) {  } //change playerID player name

        public string createLocalRoom(string playerID, uint nPlayers) { return null; } //create local room for nPlayers numbers and return Room ID
        public string createRoom(string playerID, uint nPlayers) { return null; }
        public string enterRoom(string playerID, string roomID) { return null; } //enter player with global PlayerID into room with RoomID and return GameID
        public IList<string> enterLocalRoom(string playerID, string roomID) { return null; }//enter localroom and get list of localIDs

        public string readyToStartGame(string playerID, string roomID) { return null; } //return 'wait' or gameID        
        public string makeAction(string playerID, string roomID, string gameID, string actionID) { return null; } //make action by playerID in roomID 
                                                                                                                 //game and return last action actionId
        public IList<string> rebuildField(string playerID, string roomID, string gameID, string actionID) { return null; }//return list of action after action with actionID, 
                                                                                                                           //rewrite last acionID
        public IList<string> isAnyOneLeftGame(string playerID, string roomID, string gameID) { return null; } //return NAMES of lefted players
        public string isGameOver(string playerID, string roomID, string gameID) { return null; } //return 'No' or winner NAME

        public void giveUp(string playerID, string roomID, string gameID) { }
        public string askToRestartGame(string playerID, string gameID, string roomID) { return null; } //game with GameID in room with RoomID over and return new game GameID, or "No"
        public void leaveRoom(string playerID, string roomID) { } //leave room with RoomID
    }
}
