using System;
using System.Windows.Forms;
/* Kevin Tran
 * 12/10/2019
 * Fall 2019
 */

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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                string userMessage = txtMessage.Text;
                Converter c = new Converter();
                lblDisplay.Text = c.encrypt(userMessage);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                string userMessage = txtMessage.Text;
                Converter c = new Converter();
                lblDisplay.Text = c.decrypt(userMessage);
            }
        }

        public bool validateData()
        {
            return
                IsBlank(txtMessage) &&
                isLetters(txtMessage);
        }

        public bool IsBlank(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                lblDisplay.Text = "Entry box is empty, please input a value";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isLetters(TextBox textBox)
        {
            string s = textBox.Text;
            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                    return true;
            }
            lblDisplay.Text = "Entry can only contain letters";
            return false;
        }
    }
}
