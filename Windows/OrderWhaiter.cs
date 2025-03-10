using CafeBase.Classes;
using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace CafeBase.Windows
{
    public partial class OrderWhaiter: Form
    {
        SqlConnector sql = new SqlConnector();
        List<Ordern> Ordern_ = new List<Ordern>();
        public OrderWhaiter()
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
                string stm = "SELECT * FROM orders";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int orderID = reader.GetInt32(0);
                    string ReadyOrNot = reader.GetString(1);
                    int TableNumber = reader.GetInt32(2);
                    int Quantity = reader.GetInt32(3);
                    DateTime OrderDate = reader.GetDateTime(4);
                    string DishNames = reader.GetString(5);
                    int WaiterID = reader.GetInt32(6);
                    int CookID = reader.GetInt32(7);

                    Ordern order = new Ordern
                    {
                        OrderID = orderID,
                        WaiterID = WaiterID,
                        ReadyOrNot = ReadyOrNot,
                        CookID = CookID,
                        TableNumber = TableNumber,
                        Quantity = Quantity,
                        DishNames = DishNames,
                        OrderDate = OrderDate
                    };
                    Ordern_.Add(order);
                }
                Ordernnn_View.DataSource = null;
                Ordernnn_View.DataSource = Ordern_;
                Ordernnn_View.Refresh();
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

        private void TimeBox_Click(object sender, EventArgs e)
        {
            string inputDate = Interaction.InputBox("Введите дату в формате ГГГГ-ММ-ДД", "Фильтр по дате", "");

            if (DateTime.TryParse(inputDate, out DateTime filterDate))
            {
                var filteredShifts = Ordern_.Where(s => s.OrderDate.Date == filterDate.Date).ToList();
                Ordernnn_View.DataSource = null;
                Ordernnn_View.DataSource = filteredShifts;
                Ordernnn_View.Refresh();
            }
            else
            {
                MessageBox.Show("Введите корректную дату в формате ГГГГ-ММ-ДД!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Ordernnn_View.DataSource = null;
            Ordernnn_View.DataSource = Ordern_; 
            Ordernnn_View.Refresh();
        }
    }
}
