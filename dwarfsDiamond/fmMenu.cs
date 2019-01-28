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
    public partial class fmMenu : Form
    {
        IGameMaster m_pClient, m_pLocalServer;
        fmLocalRoom m_formLocalRoom;
       

        public fmMenu()
        {
            InitializeComponent();
            hideShowLogin(true);
            hideShowMenu(false);
            m_pLocalServer = new CServer();
            m_pClient = new CClient(m_pLocalServer);
        }

        void hideShowMenu(bool isShow)
        {
            btnCreateNet.Visible = isShow;
            btnCreateLocal.Visible = isShow;
            btnConnect.Visible = isShow;
            lblWelcome.Visible = isShow;

        }
        void hideShowLogin(bool isShow)
        {
            btnLogin.Visible = isShow;
            tbxLogin.Visible = isShow;
            lblWelcome.Visible = isShow;
            lblLogin.Visible = isShow;
        }
        void login()
        {
            try
            {
                string name = m_pClient.createNewPlayer(tbxLogin.Text);
                hideShowLogin(false);
                hideShowMenu(true);               
                lblWelcome.Text += name;
            }
            catch (FormatException exc)
            {
                MessageBox.Show(exc.Message);
                tbxLogin.Clear();
            }
           
        }
        void closed()
        {
            if (m_formLocalRoom != null)
            {
                m_formLocalRoom.Dispose();

            }
            m_pClient = null;
            m_pLocalServer = null;
            m_formLocalRoom = null; ;
        }
        void createLocalRoom()
        {
            initiateLocalRoom();
            
            this.Hide();
            m_formLocalRoom.Show();
        }
        void initiateLocalRoom()
        {
            m_formLocalRoom = new fmLocalRoom(m_pClient, this);
                      
        }
        void mockNetGames()
        {
            MessageBox.Show("Сетевая игра пока недоступна");
        }

        private void btnCreateNet_Click(object sender, EventArgs e)
        {
            mockNetGames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mockNetGames();
        }

        private void  tbxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                login();
            }
        }

        private void btnCreateLocal_Click(object sender, EventArgs e)
        {
            createLocalRoom();
        }

        private void fmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
           closed();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
