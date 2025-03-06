using CafeBase.Classes;
using CafeBase.ConnectSQL;
using CafeBase.Windows;
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

namespace CafeBase
{
    public partial class Waiter: Form
    {
        List<Ordern> orders_ = new List<Ordern>();
        SqlConnector sql = new SqlConnector();
        public Waiter()
        {
            InitializeComponent();
            LoadOrdens();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            this.Hide();
            MainForm MH = new MainForm();
            MH.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddOrderForm AD = new AddOrderForm();
            AD.Show();
        }

        private void Waiter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shifts shifts = new Shifts();
            shifts.Show();
        }
    }
}
