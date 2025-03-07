using CafeBase.Classes;
using CafeBase.Trash;
using System;
using System.Windows.Forms;

namespace CafeBase
{
    public partial class OpenDialogAdmin: Form
    {
        public OpenDialogAdmin()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void OpenAdminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator Admin = new Administrator();
            Admin.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MH = new MainForm();
            MH.Show();
        }

        private void OpenDialogAdmin_Load(object sender, EventArgs e)
        {

        }

        private void Zakazy_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdernS OP = new OrdernS();
            OP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShiftsADM SHD = new ShiftsADM();
            SHD.Show();
        }
    }
}
