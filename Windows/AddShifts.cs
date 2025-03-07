using CafeBase.Classes;
using CafeBase.ConnectSQL;
using CafeBase.Trash;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeBase.Windows
{
    public partial class AddShifts: Form
    {
        SqlConnector sql = new SqlConnector();
        List<Users> use_ = new List<Users>();
        List<SShifts> shifts_ = new List<SShifts>();
        public AddShifts()
        {
            InitializeComponent();
            UserIDKiad();
            LoadPOOP();
            UserIDView.SelectionChanged += UserIDView_SelectionChanged;
            ViewUpload.SelectionChanged += ViewUpload_SelectionChanged;
        }
        private void UserIDView_SelectionChanged(object sender, EventArgs e)
        { 
         int number = UserIDView.CurrentRow.Index;
            Users X = use_[number];
            UserID_Box.Text = X.id.ToString();
        }
        private void ViewUpload_SelectionChanged(object sender, EventArgs e)
        { 
         int numbers = ViewUpload.CurrentRow.Index;
         SShifts Y = shifts_[numbers];
         Data_Box.Text = Y.ShiftsDate.ToString("yyyy-MM-dd");
         Time_Box.Text = Y.Shiftstime.ToString(@"hh\:mm\:ss");
        }
        private void LoadPOOP()
        {
            string cs = sql.Getconnect();
            try
            {
             var con = new MySqlConnection(cs);
             con.Open();
             var stm = "SELECT id , Userid , ShiftsDate , Shiftstime FROM shifts";
             var cmd = new MySqlCommand(stm , con);
             MySqlDataReader reader = cmd.ExecuteReader();
             shifts_.Clear();
             while (reader.Read())
             {
               int id = reader.GetInt32(0);
               int Userid = reader.GetInt32(1);
               DateTime ShiftsDate = reader.GetDateTime(2);
               TimeSpan Shiftstime = reader.GetTimeSpan(3);

                    SShifts sShifts_ = new SShifts
                    {

                        id = id,
                        Userid = Userid,
                        ShiftsDate = ShiftsDate,
                        Shiftstime = Shiftstime
                    };
                    shifts_.Add(sShifts_);
             }
                ViewUpload.DataSource = null;
                ViewUpload.DataSource = shifts_;
                ViewUpload.Refresh();
                con.Close();
            }
            catch(Exception ex)
            {
             MessageBox.Show(ex.Message);
            }
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
                use_.Clear();
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
                ViewUpload.Refresh();
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
        private void AdddButton()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = $"INSERT INTO shifts (UserID , ShiftsDate ,Shiftstime ) VALUES ('{UserID_Box.Text}' , '{Data_Box.Text}' , '{Time_Box.Text}') ";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      /*  private void change()
        {

            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = $"UPDATE shifts SET ShiftsDate = '{Data_Box.Text}', Shiftstime = '{Time_Box.Text}' WHERE UserID = '{UserID_Box.Text}'";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      */
        private void button1_Click(object sender, EventArgs e)
        {
            AdddButton();
            LoadPOOP();
        }

        //private void Chage_b_Click(object sender, EventArgs e)
        //{
          //  change();
            //LoadPOOP();
        //}
    }
}
