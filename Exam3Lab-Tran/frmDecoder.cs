using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam3Lab_Tran
{
    public partial class frmDecoder : Form
    {
        public frmDecoder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmDecoder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnExit.PerformClick();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            lblDisplay.Text = "";
        }
    }
}
