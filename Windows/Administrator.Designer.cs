namespace CafeBase
{
    partial class Administrator
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
            this.Exit = new System.Windows.Forms.Button();
            this.UserView = new System.Windows.Forms.DataGridView();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Surname_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Change = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.TestClone = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Job_Title_Box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(520, 334);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(71, 22);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UserView
            // 
            this.UserView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserView.Location = new System.Drawing.Point(9, 10);
            this.UserView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserView.Name = "UserView";
            this.UserView.ReadOnly = true;
            this.UserView.RowHeadersWidth = 51;
            this.UserView.RowTemplate.Height = 24;
            this.UserView.Size = new System.Drawing.Size(582, 122);
            this.UserView.TabIndex = 1;
            this.UserView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserView_CellContentClick);
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(74, 160);
            this.Name_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(174, 20);
            this.Name_box.TabIndex = 2;
            // 
            // Surname_Box
            // 
            this.Surname_Box.Location = new System.Drawing.Point(74, 183);
            this.Surname_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Surname_Box.Name = "Surname_Box";
            this.Surname_Box.Size = new System.Drawing.Size(174, 20);
            this.Surname_Box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус";
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(266, 250);
            this.Change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(71, 25);
            this.Change.TabIndex = 10;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(596, 10);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(8, 20);
            this.ID_Box.TabIndex = 11;
            // 
            // TestClone
            // 
            this.TestClone.FormattingEnabled = true;
            this.TestClone.Items.AddRange(new object[] {
            "Уволен",
            "Активен"});
            this.TestClone.Location = new System.Drawing.Point(74, 230);
            this.TestClone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TestClone.Name = "TestClone";
            this.TestClone.Size = new System.Drawing.Size(174, 21);
            this.TestClone.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 160);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Job_Title_Box
            // 
            this.Job_Title_Box.FormattingEnabled = true;
            this.Job_Title_Box.Items.AddRange(new object[] {
            "Администратор",
            "Официант",
            "Повар"});
            this.Job_Title_Box.Location = new System.Drawing.Point(74, 206);
            this.Job_Title_Box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Job_Title_Box.Name = "Job_Title_Box";
            this.Job_Title_Box.Size = new System.Drawing.Size(174, 21);
            this.Job_Title_Box.TabIndex = 14;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Job_Title_Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TestClone);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Surname_Box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.UserView);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.UserView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView UserView;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Surname_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.ComboBox TestClone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Job_Title_Box;
    }
}