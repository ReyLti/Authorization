using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Authorization
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            int Left = Width / 3; //для текстбоксов
            int LeftLeft = Width / 15; //для названия и кнопки на главную
            int Top = Width / 4; //для кнопок
            string Name = "Sign In";
            string MainName = "Go main";
            Font Arial = new Font("Arial",8);
            tb_Login.Font = Arial;
            tb_Password.Font = Arial;
            btn_SignIn.Font = Arial;
            btn_Main.Font = Arial;
            Arial = new Font("Arial", 16);
            l_Name.Text = Name;
            l_Name.Font = Arial;
            l_Name.Left = LeftLeft;
            l_Name.Top = Height / 15;
            tb_Login.Left = Left;
            tb_Password.Left = Left;
            btn_SignIn.Left = Left;
            tb_Login.Top = Height / 5;
            tb_Password.Top = Height / 3;
            tb_Password.UseSystemPasswordChar = true;
            btn_SignIn.Top = Top;
            btn_SignIn.Text = Name;
            btn_Main.Text = MainName;
            btn_Main.Top = Top;
            btn_Main.Left = LeftLeft;
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            Hide();
            Main.Show();

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string con = "";
            string Name = ""; //имя сущности
            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();   // открываем подключение
                SqlCommand command = new SqlCommand();
                command.CommandText = $"SELECT idRole FROM {Name} where Login = {tb_Login} and Password = {tb_Password}";
                command.Connection = connect;
                string answer = command.ExecuteReader().ToString(); //?????????????????????????
            }
        }
    }
}
