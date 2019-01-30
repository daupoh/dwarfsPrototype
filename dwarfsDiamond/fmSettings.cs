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
    public partial class fmSettings : Form
    {
        fmGameField m_pGameFieldForm;
        CSettings m_pSettings;
      
        public fmSettings()
        {
            InitializeComponent();
            m_pSettings = new CSettings(9, 4);
        }
        public CSettings Settings { get { return m_pSettings; } }
        

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            m_pSettings.CountOfEnemies = (int)numCountOfPlayers.Value;
            m_pGameFieldForm = new fmGameField(this);            
            m_pGameFieldForm.Show();
            this.Hide();
        }
    }
}
