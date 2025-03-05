using CafeBase.ConnectSQL;
using CafeBase.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeBase
{
    public partial class MainForm : Form
    {
        SqlConnector SQL = new SqlConnector();
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void LogIN_Click(object sender, EventArgs e)
        {
            string cs = SQL.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = String.Format("SELECT Name, Surname , Job_title , Status FROM access_rights WHERE Login = \"{0}\" AND password = \"{1}\"",
                Login1.Text,
                Password.Text);
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {

                    string name = Reader.GetString(0);
                    string Surname = Reader.GetString(1);
                    string Job_title = Reader.GetString(2);
                    string Status = Reader.GetString(3);
                    if (Status == "Активен")
                    {
                        MessageBox.Show("Успешно вошли " + " " + name + " " + Surname);
                        invate(Job_title);
                    }
                    else if (Status == "Уволен")
                    {
                        MessageBox.Show("Вы забанены");
                        con.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Не верный Login или Password ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);

            }

        }


        public void invate(string Job_title)
        {
            switch (Job_title)
            {
                case "Администратор":
                    {
                        this.Hide();
                        OpenDialogAdmin ad = new OpenDialogAdmin();
                        ad.Show();
                        break;
                    }
                case "Официант":
                    {
                        this.Hide();
                        Waiter wh = new Waiter();
                        wh.Show();
                        break;
                    }
                case "Повар":
                    {
                        this.Hide();
                        l Cook = new l();
                        Cook.Show();
                        break;
                    }
                default:
                    MessageBox.Show("Неизвестная роль.");
                    this.Show();
                    break;
            }
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
