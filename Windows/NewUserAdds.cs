using CafeBase.ConnectSQL;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeBase.Windows
{
   
    public partial class NewUserAdds: Form
    {
        SqlConnector sql = new SqlConnector();
        public NewUserAdds()
        {
            InitializeComponent();
            Status_Box.Text = "Активен";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator AD = new Administrator();
            AD.Show();
        }
        private void ChangeUsers()
        {
            string cs = sql.Getconnect();
            try
            {
                var con = new MySqlConnection(cs);

                con.Open();
                var stm = $"INSERT INTO access_rights (Name, Surname, Job_title, Status , Login , Password) " +
                     $"VALUES ('{Name_Box.Text}', '{Surname_Box.Text}', '{Job_Title_Box.Text}', '{Status_Box.Text}' , '{Login_box.Text}','{Password_Box.Text}')";

                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader Reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            catch (Exception Exept)
            {

                MessageBox.Show(Exept.Message);

            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            ChangeUsers();
        }
    }
}
