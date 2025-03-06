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
            this.Close.Location = new System.Drawing.Point(524, 202);
            this.Close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(68, 25);
            this.Close.TabIndex = 0;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(507, 10);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 25);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(9, 18);
            this.Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(133, 13);
            this.Name.TabIndex = 2;
            this.Name.Text = "Введите имя сотрудника";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(9, 45);
            this.Surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(161, 13);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Введите фамилию сотрудника";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(9, 100);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(161, 13);
            this.Login.TabIndex = 4;
            this.Login.Text = "Придумайте логин сотруднику";
            // 
            // Passwd
            // 
            this.Passwd.AutoSize = true;
            this.Passwd.Location = new System.Drawing.Point(9, 130);
            this.Passwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(168, 13);
            this.Passwd.TabIndex = 5;
            this.Passwd.Text = "Придумайте пароль сотруднику";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(9, 154);
            this.Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(47, 13);
            this.Status.TabIndex = 6;
            this.Status.Text = "Статус :";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(181, 15);
            this.Name_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(192, 20);
            this.Name_Box.TabIndex = 7;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(181, 42);
            this.Surname_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.Size = new System.Drawing.Size(192, 20);
            this.Surname_Box.TabIndex = 8;
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(181, 100);
            this.Login_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(192, 20);
            this.Login_box.TabIndex = 9;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(181, 130);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(192, 20);
            this.Password_Box.TabIndex = 10;
            // 
            // Status_Box
            // 
            this.Status_Box.Location = new System.Drawing.Point(58, 154);
            this.Status_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Status_Box.Name = "Status_Box";
            this.Status_Box.ReadOnly = true;
            this.Status_Box.Size = new System.Drawing.Size(80, 20);
            this.Status_Box.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
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
            this.Job_Title_Box.Location = new System.Drawing.Point(181, 76);
            this.Job_Title_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Job_Title_Box.Name = "Job_Title_Box";
            this.Job_Title_Box.Size = new System.Drawing.Size(192, 21);
            this.Job_Title_Box.TabIndex = 13;
            // 
            // NewUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 237);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            //this.Name = "NewUserAdds";
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