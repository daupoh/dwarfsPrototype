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
    public partial class fmAskStowns : Form
    {
        bool m_bGuessCounter = false, m_bGuessTypes = false;
        public fmAskStowns()
        {
            InitializeComponent();
            m_bGuessCounter = true;
        }
        void isBlockedCountAsk(bool blocked)
        {
            gbxNumbersOfStown.Enabled = blocked;
        }
        void isBlockedTypeAsk(bool blocked)
        {
            gbxTypeOfStowns.Enabled = blocked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (m_bGuessCounter)
            {
                isBlockedCountAsk(false);
                isBlockedTypeAsk(true);
                m_bGuessTypes = true;
                m_bGuessCounter = false;
            }
            if (m_bGuessTypes)
            {
                isBlockedCountAsk(false);
                isBlockedTypeAsk(true);
            }
        }
    }
}
