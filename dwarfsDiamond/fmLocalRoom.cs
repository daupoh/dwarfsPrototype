using dwarfsDiamond.models.Client_Server;
using dwarfsDiamond.models.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dwarfsDiamond
{
    public partial class fmLocalRoom : Form
    {
        IGameMaster  m_pClient;
        fmMenu m_formMainMenu;
        string m_sRoomID = "", m_sGameID;
        public fmLocalRoom(IGameMaster client, fmMenu menu)
        {
            InitializeComponent();
            m_pClient = client;
            m_formMainMenu = menu;
        }
        public void Dispose() {
            m_pClient = null;
            m_formMainMenu = null;
        }
        void startLocalGame()
        {
            m_sRoomID = m_pClient.createLocalRoom
                ((m_pClient as CClient).ClientName,(uint)numCountOfPlayers.Value);
        }
        private void fmLocalRoom_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_formMainMenu.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startLocalGame();
        }
    }
}
