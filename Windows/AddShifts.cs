using CafeBase.Classes;
using CafeBase.ConnectSQL;
using CafeBase.Trash;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeBase.Windows
{
    public partial class AddShifts: Form
    {
        SqlConnector sql = new SqlConnector();
        List<Users> use_ = new List<Users>();
        public AddShifts()
        {
            InitializeComponent();
            UserIDKiad();
        }
        private void UserIDKiad()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                string stm = "SELECT id , name , surname FROM access_rights";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string Surname = reader.GetString(2);

                    Users user = new Users
                    {
                        id = id,
                        Name = name,
                        Surname = Surname
                    };
                    use_.Add(user);
                }
                UserIDView.DataSource = null;
                UserIDView.DataSource = use_;
                UserIDView.Columns["Job_title"].Visible = false;
                UserIDView.Columns["Status"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShiftsADM sda = new ShiftsADM();
            sda.Show();

        }
    }
}
