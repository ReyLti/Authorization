using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authorization
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Name = "Main page";
            string Text = "Sign In";
            Font Arial = new Font("Arial", 16);
            l_Name.Text = Name;
            l_Name.Font = Arial;
            l_Name.Left = Width/15;
            l_Name.Top = Height / 15;
            btn_SignIn.Text = Text;
            btn_SignIn.Left = Width / 4;
            btn_SignIn.Top = Height / 3;
            btn_SignIn.Font = Arial;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Form signIn = new SignIn();
            Hide();
            signIn.Show();
        }
    }
}
