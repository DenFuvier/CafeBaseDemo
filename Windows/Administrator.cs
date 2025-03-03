using CafeBase.Classes;
using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MH = new MainForm();
            MH.Show();
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
                var stm = "SELECT id , Name , Surname , Job_title , Status FROM access_rights";
            //   var stm = String.Format("UPDATE users SET Name = '{0}', Surname = '{1}', Job_title = '{2}', Status = '{3}' WHERE Login = '{0}'",
               var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    int id = Reader.GetInt32(0);
                    string name = Reader.GetString(1);
                    string Surname = Reader.GetString(2);
                    string Job_title = Reader.GetString(3);
                    string Status = Reader.GetString(4);
                    Users use = new Users
                    {
                        id = id,
                        Name = name,
                        Surname = Surname,
                        Job_title = Job_title,
                        Status = Status
                    };
                    users_.Add(use);
                    UserView.DataSource = null;

                    UserView.DataSource = users_;
                }
                con.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
