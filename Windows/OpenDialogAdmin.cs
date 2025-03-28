using CafeBase.Trash;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            OpenAdminForm.MouseLeave += OpenAdminForm_MouseLeave;
            OpenAdminForm.MouseEnter += OpenAdminForm_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            Zakazy.MouseLeave += Zakazy_MouseLeave;
            Zakazy.MouseEnter += Zakazy_MouseEnter;
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

        private void Zakazy_MouseEnter(object sender, EventArgs e)
        {
            Zakazy.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void Zakazy_MouseLeave(object sender, EventArgs e)
        {
            Zakazy.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FFFFF");
        }

        private void OpenAdminForm_MouseEnter(object sender, EventArgs e)
        {
            OpenAdminForm.BackColor = ColorTranslator.FromHtml("#F4E8D3");
        }

        private void OpenAdminForm_MouseLeave(object sender, EventArgs e)
        {
            OpenAdminForm.BackColor = ColorTranslator.FromHtml("#FFFFF");
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
