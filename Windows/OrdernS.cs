using CafeBase.Classes;
using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CafeBase
{
    public partial class OrdernS: Form
    {
        List<Ordern> orders_ = new List<Ordern>();
        SqlConnector sql = new SqlConnector();
        public OrdernS()
        {
            InitializeComponent();
            LoadOrdens();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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

        private void LoadOrdens()
        { 
         string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "SELECT * FROM orders";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();

                orders_.Clear();
                while (Reader.Read())
                {
                    int OrderID = Reader.GetInt32(0);
                    string ReadyOrNot = Reader.GetString(1);
                    int TableNumber = Reader.GetInt32(2);
                    int Quantity = Reader.GetInt32(3);
                    DateTime OrderDate = Reader.GetDateTime(4);
                    string DishNames = Reader.GetString(5);
                    int WaiterID = Reader.GetInt32(6);
                    int CookID = Reader.GetInt32(7);
                 
               
                    Ordern use = new Ordern
                    {
                        OrderID = OrderID,
                        WaiterID = WaiterID,
                        CookID = CookID,
                        TableNumber = TableNumber,
                        Quantity = Quantity,
                        OrderDate = OrderDate,
                        DishNames = DishNames,
                        ReadyOrNot = ReadyOrNot
                    };
                    orders_.Add(use);
                   
                }
                ViewOrdernS.DataSource = null;
                ViewOrdernS.DataSource = orders_;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заказов: {ex.Message}");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            OpenDialogAdmin MH = new OpenDialogAdmin();
            MH.Show();
            this.Close();
            
        }
    }
}
