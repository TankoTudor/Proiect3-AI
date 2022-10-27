using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect3_AI
{
    public partial class Antrenament : Form
    {
        public Antrenament()
        {
            InitializeComponent();
        }

        private void nrHLNUD_ValueChanged(object sender, EventArgs e)
        {
            if(nrHLNUD.Value == 1)
            {
                hl2Label.Visible = false;
                neuHL2NUD.Visible = false;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if(nrHLNUD.Value == 2)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = false;
                neuHL3NUD.Visible = false;
            }
            if(nrHLNUD.Value == 3)
            {
                hl2Label.Visible = true;
                neuHL2NUD.Visible = true;
                hl3Label.Visible = true;
                neuHL3NUD.Visible = true;
            }
        }
    }
}
