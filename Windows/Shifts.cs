using CafeBase.Classes;
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
                    int id = reader.GetInt32(1);
                    int userid = reader.GetInt32(2);
                    DateTime ShiftsDate = reader.GetDateTime(3);
                    DateTime Shiftstime = reader.GetDateTime(4);

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
    }
}
