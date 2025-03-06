﻿using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeBase.Windows
{
    public partial class AddOrderForm : Form
    {
        List<Order> orders_ = new List<Order>();
        SqlConnector sql = new SqlConnector();
        public AddOrderForm()
        {
            InitializeComponent();
            DataBoxTime.Click += DataBoxTime_Click;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            RadioOK.Click += RadioOK_Click;
            RadioNOT.Click += RadioNOT_Click;
        }
        private void RadioOK_Click(object sender, EventArgs e)
        {
            DataBoxTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            textBox1.Text = "Не готово";
            textBox2.Text = "7";
            textBox3.Text = "2";
        }
        private void RadioNOT_Click(object sender, EventArgs e)
        {
            DataBoxTime.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void DataBoxTime_Click(object sender, EventArgs e)
        {
            
        }
        private void exitthis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waiter W = new Waiter();
            W.Show();
        }
        private void AddOderd()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = $"INSERT INTO orders (OrderDate, TableNumber, Quantity, DishNames , WaiterID , CookID) VALUES ('{DataBoxTime.Text}', '{TableNumberBox.Text}', '{ClientInt.Text}', '{NameBoxDish.Text}' , '{textBox2.Text}' , {textBox3.Text})";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private void PlusDish_Click(object sender, EventArgs e)
        {
            AddOderd();
        }
    }
}
