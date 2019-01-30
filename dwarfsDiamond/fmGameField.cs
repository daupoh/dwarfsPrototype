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
    public partial class fmGameField : Form
    {
        fmSettings m_pStartGameSettings;
        public fmGameField(fmSettings settingForm)
        {
            InitializeComponent();
            m_pStartGameSettings = settingForm;
            initiateArm();
            initiateEnemies();
            initiateHint();
        }
        void initiateArm()
        {
            int nStowns = m_pStartGameSettings.Settings.CountOfStowns,
                nForms = m_pStartGameSettings.Settings.CountOfStownForms;

            dgvArm.ColumnCount =nStowns;
            dgvArm.RowCount = nForms;
            

            for (int i = 0; i < nForms; i++)
            {
                dgvArm.Rows[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getFormName(i);
            }
           
            dgvArm.ColumnHeadersVisible = false;
        }
        void initiateHint()
        {
            tbxHint.Text = m_pStartGameSettings.Settings.Hint;
        }
        void initiateEnemies()
        {
            int nEnemies = m_pStartGameSettings.Settings.CountOfEnemies,
                nFields = m_pStartGameSettings.Settings.CountOfFields;
            dgvEnemies.RowCount = nEnemies;
            dgvEnemies.ColumnCount = nFields;
            for (int i = 0; i < nEnemies; i++)
            {
                dgvEnemies.Rows[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getEnemiesName(i);
            }
            for (int i = 0; i < nFields; i++)
            {
                dgvEnemies.Columns[i].HeaderCell.Value = m_pStartGameSettings.Settings
                    .getFieldName(i);
            }
        }

        private void fmGameField_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_pStartGameSettings.Show();
        }

      
    }
}
