using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_lodinpage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Please contact the administrator to reset your password.",
        "Forgot Password",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "Hafeez") && (txtPassword.Text == "12345"))
            {
                MessageBox.Show("Login Successful","Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Failed!", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(572, 382);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
    }
}
