namespace CafeBase.Windows
{
    partial class AddShifts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserIDView = new System.Windows.Forms.DataGridView();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.UserID_Box = new System.Windows.Forms.TextBox();
            this.Data_Box = new System.Windows.Forms.TextBox();
            this.Time_Box = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.ViewUpload = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UserIDView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUpload)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserdID сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Время";
            // 
            // UserIDView
            // 
            this.UserIDView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserIDView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserIDView.Location = new System.Drawing.Point(12, 12);
            this.UserIDView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIDView.Name = "UserIDView";
            this.UserIDView.ReadOnly = true;
            this.UserIDView.RowHeadersWidth = 51;
            this.UserIDView.RowTemplate.Height = 24;
            this.UserIDView.Size = new System.Drawing.Size(881, 116);
            this.UserIDView.TabIndex = 4;
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(-4, 0);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(9, 22);
            this.ID_Box.TabIndex = 5;
            // 
            // UserID_Box
            // 
            this.UserID_Box.Location = new System.Drawing.Point(163, 260);
            this.UserID_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserID_Box.Name = "UserID_Box";
            this.UserID_Box.Size = new System.Drawing.Size(225, 22);
            this.UserID_Box.TabIndex = 6;
            // 
            // Data_Box
            // 
            this.Data_Box.Location = new System.Drawing.Point(163, 290);
            this.Data_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_Box.Name = "Data_Box";
            this.Data_Box.Size = new System.Drawing.Size(225, 22);
            this.Data_Box.TabIndex = 7;
            // 
            // Time_Box
            // 
            this.Time_Box.Location = new System.Drawing.Point(163, 318);
            this.Time_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Time_Box.Name = "Time_Box";
            this.Time_Box.Size = new System.Drawing.Size(225, 22);
            this.Time_Box.TabIndex = 8;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(767, 346);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 34);
            this.exit.TabIndex = 9;
            this.exit.Text = "Вернуться";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(396, 260);
            this.Upload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(141, 37);
            this.Upload.TabIndex = 10;
            this.Upload.Text = "Добавить";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewUpload
            // 
            this.ViewUpload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewUpload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUpload.Location = new System.Drawing.Point(12, 134);
            this.ViewUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewUpload.Name = "ViewUpload";
            this.ViewUpload.RowHeadersWidth = 51;
            this.ViewUpload.Size = new System.Drawing.Size(881, 116);
            this.ViewUpload.TabIndex = 11;
            // 
            // AddShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(896, 394);
            this.Controls.Add(this.ViewUpload);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Time_Box);
            this.Controls.Add(this.Data_Box);
            this.Controls.Add(this.UserID_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.UserIDView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddShifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddShifts";
            ((System.ComponentModel.ISupportInitialize)(this.UserIDView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUpload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UserIDView;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.TextBox UserID_Box;
        private System.Windows.Forms.TextBox Data_Box;
        private System.Windows.Forms.TextBox Time_Box;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.DataGridView ViewUpload;
    }
}