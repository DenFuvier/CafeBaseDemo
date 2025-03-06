using CafeBase.Classes;
using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeBase.Windows
{
    public partial class l: Form
    {
        List<Ordern> orderss_ = new List<Ordern>();
        SqlConnector sql = new SqlConnector();
        public l()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            ID_box.Hide();
            LoadOrdens();
            ViewOrdernSS.SelectionChanged += ViewOrdernSS_SelectionChanged;
        }
        private void ViewOrdernSS_SelectionChanged(object sender, EventArgs e)
        {
            int number = ViewOrdernSS.CurrentRow.Index;
            Ordern X = orderss_[number];
            StatusFood.Text = X.ReadyOrNot;
            textBox1.Text = X.DishNames;
            ID_box.Text = X.OrderID.ToString();
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

                orderss_.Clear();
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
                    orderss_.Add(use);

                }
                ViewOrdernSS.DataSource = null;
                ViewOrdernSS.DataSource = orderss_;
               
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

        private void Change_Click(object sender, EventArgs e)
        {
            UpdateFood();
            LoadOrdens();
            ViewOrdernSS.Refresh();
        }
        private void UpdateFood()
        {
            string cs = sql.Getconnect();
            try
            {
                using (var con = new MySqlConnection(cs))
                {
                    con.Open();
                    var stm = $"UPDATE orders SET ReadyOrNot = '{StatusFood.Text}' WHERE OrderID = '{ID_box.Text}'";

                    var cmd = new MySqlCommand(stm, con);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
