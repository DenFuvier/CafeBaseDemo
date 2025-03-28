using CafeBase.Classes;
using CafeBase.ConnectSQL;
using CafeBase.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeBase
{
    public partial class Administrator: Form
    {
        List<Users> users_ = new List<Users>();
        SqlConnector sql = new SqlConnector();
        public Administrator()
        {
            InitializeComponent();
            loadUsers();
            UserView.SelectionChanged += UserView_SelectionChanged;
            ID_Box.Hide();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseEnter += button1_MouseEnter;
            Change.MouseLeave += Change_MouseLeave;
            Change.MouseEnter += Change_MouseEnter;
            Exit.MouseLeave += Exit_MouseLeave;
            Exit.MouseEnter += Exit_MouseEnter;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void Change_MouseEnter(object sender, EventArgs e)
        {
            Change.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void Change_MouseLeave(object sender, EventArgs e)
        {
            Change.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenDialogAdmin ODA = new OpenDialogAdmin();
            ODA.Show();
        }
        private void UserView_SelectionChanged(object sender, EventArgs e)
        {
            int number = UserView.CurrentRow.Index;
            Users X = users_[number];
            ID_Box.Text = X.id.ToString();
            Name_box.Text = X.Name;
            Surname_Box.Text = X.Surname;
            Job_Title_Box.Text = X.Job_title;
            TestClone.Text = X.Status;
        }
        private void UserView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadUsers()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();

                var stm = "SELECT id, Name, Surname, Job_title, Status FROM access_rights";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                users_.Clear();  

                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string name = Reader.GetString(1);
                    string surname = Reader.GetString(2);
                    string job_title = Reader.GetString(3);
                    string status = Reader.GetString(4);

                    Users use = new Users
                    {
                        id = id,
                        Name = name,
                        Surname = surname,
                        Job_title = job_title,
                        Status = status
                    };

                    users_.Add(use);
                }
                UserView.DataSource = null;
                UserView.DataSource = users_;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChangeUsers()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);

                con.Open();



                var stm = $"UPDATE access_rights SET Name = '{Name_box.Text}', " + $"Surname = '{Surname_Box.Text}', Job_title = '{Job_Title_Box.Text}', " +
                          $"Status = '{TestClone.Text}' " + $"WHERE id = '{ID_Box.Text}'";

                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception Exept)
            {

                MessageBox.Show(Exept.Message);

            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            ChangeUsers();
            loadUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserAdds AS = new NewUserAdds();
            AS.Show();
        }
    }
}
