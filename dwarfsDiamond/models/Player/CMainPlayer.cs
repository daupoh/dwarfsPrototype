using dwarfsDiamond.models.GameMaster;
using dwarfsDiamond.models.Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Player
{
    class CMainPlayer : IPlayer
    {
        string m_sName = "";
        IGameMaster m_pGameMaster = null;
        IArm m_pArm=null;
        IList<ISet> m_lsSets;

        public CMainPlayer(string name,IGameMaster gm)
        {
            checkName(name);
            checkGameMaster(gm);
            m_sName = name;
            m_pGameMaster = gm;
            m_lsSets = new List<ISet>();      
        }

        public string Name
        {
            get
            {
                return m_sName;
            }
        }

        public void askPlayerForStown(IPlayer anotherPlayer, string stownsName)
        {
            m_pGameMaster.playerAskAnother(this, anotherPlayer, stownsName);
        }

        public void checkSetsInArm()
        {
            ISet[] sets = m_pArm.checkSets();
            if (sets.Length != 0) {
                foreach (ISet s in sets)
                {
                    m_lsSets.Add(s);
                }
            }
        }

        public void grabStownFromDek()
        {
            m_pGameMaster.getStownFromDekToPlayer(this);
        }

        public bool haveInCount(int stownsCount)
        {
            return m_pArm.haveInCount(stownsCount);
        }

        public bool haveInTypes(string[] types, int len)
        {
            return m_pArm.haveInTypes(types, len);
        }

        public bool haveStown(string stownsName)
        {
            return m_pArm.haveStown(stownsName);
        }

        void checkName(string name)
        {
            if (name==null || name=="")
            {
                throw new FormatException("Имя не может быть пустым.");
            }
        }
        void checkGameMaster(IGameMaster gm)
        {
            if (gm==null)
            {
                throw new FormatException("Игровой мастер не может быть null,");
            }
        }
    }
}
