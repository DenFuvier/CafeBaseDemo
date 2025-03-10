﻿using CafeBase.Classes;
using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeBase.Windows
{
    public partial class Shifts: Form
    {
        SqlConnector sql = new SqlConnector();
        List<SShifts> shifts_ = new List<SShifts>();
        List<Users> use_ = new List<Users>();
        public Shifts()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            LoadShift();
        }
     
        private void LoadShift()
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
                Shift_View.DataSource = null;
                 Shift_View.DataSource  = shifts_;
                Shift_View.Refresh();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiter WH = new Waiter();
            WH.Show();
        }
    }
}
