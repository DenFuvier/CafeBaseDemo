namespace CafeBase.Windows
{
    partial class NewUserAdds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Close = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.Passwd = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.Surname_Box = new System.Windows.Forms.TextBox();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Status_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Job_Title_Box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(699, 249);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(91, 31);
            this.Close.TabIndex = 0;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(676, 12);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(112, 31);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 22);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(170, 16);
            this.Name.TabIndex = 2;
            this.Name.Text = "Введите имя сотрудника";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(12, 55);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(208, 16);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Введите фамилию сотрудника";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(12, 123);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(210, 16);
            this.Login.TabIndex = 4;
            this.Login.Text = "Придумайте логин сотруднику";
            // 
            // Passwd
            // 
            this.Passwd.AutoSize = true;
            this.Passwd.Location = new System.Drawing.Point(12, 160);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(219, 16);
            this.Passwd.TabIndex = 5;
            this.Passwd.Text = "Придумайте пароль сотруднику";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 190);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(59, 16);
            this.Status.TabIndex = 6;
            this.Status.Text = "Статус :";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(241, 18);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(255, 22);
            this.Name_Box.TabIndex = 7;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(241, 52);
            this.Surname_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.Size = new System.Drawing.Size(255, 22);
            this.Surname_Box.TabIndex = 8;
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(241, 123);
            this.Login_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(255, 22);
            this.Login_box.TabIndex = 9;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(241, 160);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(255, 22);
            this.Password_Box.TabIndex = 10;
            // 
            // Status_Box
            // 
            this.Status_Box.Location = new System.Drawing.Point(77, 190);
            this.Status_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Status_Box.Name = "Status_Box";
            this.Status_Box.ReadOnly = true;
            this.Status_Box.Size = new System.Drawing.Size(105, 22);
            this.Status_Box.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Введите должность";
            // 
            // Job_Title_Box
            // 
            this.Job_Title_Box.FormattingEnabled = true;
            this.Job_Title_Box.Items.AddRange(new object[] {
            "Администратор",
            "Официант",
            "Повар"});
            this.Job_Title_Box.Location = new System.Drawing.Point(241, 94);
            this.Job_Title_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Job_Title_Box.Name = "Job_Title_Box";
            this.Job_Title_Box.Size = new System.Drawing.Size(255, 24);
            this.Job_Title_Box.TabIndex = 13;
            // 
            // NewUserAdds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.Job_Title_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status_Box);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Surname_Box);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.Close);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
           // this.Name = "NewUserAdds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Passwd;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.TextBox Surname_Box;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.TextBox Status_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Job_Title_Box;
    }
}