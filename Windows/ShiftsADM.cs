using CafeBase.Classes;
using CafeBase.ConnectSQL;
using CafeBase.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeBase.Trash
{
    public partial class ShiftsADM: Form
    {
        SqlConnector sql = new SqlConnector();
        List<SShifts> shifts_ = new List<SShifts>();
        List<Users> use_ = new List<Users>();
        public ShiftsADM()
        {
            InitializeComponent();
            ADM();
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            button2.MouseEnter += Button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void Button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void ADM()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                string stm = "SELECT * FROM shifts";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    int userid = reader.GetInt32(1);
                    DateTime ShiftsDate = reader.GetDateTime(2);
                    TimeSpan Shiftstime = reader.GetTimeSpan(3);

                    SShifts SH = new SShifts
                    {
                        id = id,
                        Userid = userid,
                        ShiftsDate = ShiftsDate,
                        Shiftstime = Shiftstime
                    };
                    shifts_.Add(SH);
                }
                AdminViewShifts.DataSource = null;
                AdminViewShifts.DataSource = shifts_;
                AdminViewShifts.Refresh();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddShifts ADS = new AddShifts();
            ADS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenDialogAdmin OP = new OpenDialogAdmin();
            OP.Show();

        }
    }
}
