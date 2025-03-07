namespace CafeBase.Windows
{
    partial class l
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
            this.ViewOrdernSS = new System.Windows.Forms.DataGridView();
            this.Change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusFood = new System.Windows.Forms.ComboBox();
            this.ID_box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernSS)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1364, 441);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 34);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ViewOrdernSS
            // 
            this.ViewOrdernSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrdernSS.Location = new System.Drawing.Point(12, 12);
            this.ViewOrdernSS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewOrdernSS.Name = "ViewOrdernSS";
            this.ViewOrdernSS.ReadOnly = true;
            this.ViewOrdernSS.RowHeadersWidth = 51;
            this.ViewOrdernSS.RowTemplate.Height = 24;
            this.ViewOrdernSS.Size = new System.Drawing.Size(1464, 272);
            this.ViewOrdernSS.TabIndex = 1;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(371, 346);
            this.Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(109, 33);
            this.Change.TabIndex = 2;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус заказа  :";
            // 
            // StatusFood
            // 
            this.StatusFood.FormattingEnabled = true;
            this.StatusFood.Items.AddRange(new object[] {
            "Готово",
            "Не готово"});
            this.StatusFood.Location = new System.Drawing.Point(131, 346);
            this.StatusFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusFood.Name = "StatusFood";
            this.StatusFood.Size = new System.Drawing.Size(221, 24);
            this.StatusFood.TabIndex = 5;
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(-7, -4);
            this.ID_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(12, 22);
            this.ID_box.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 305);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(531, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выбранный заказ :";
            // 
            // l
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ID_box);
            this.Controls.Add(this.StatusFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.ViewOrdernSS);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "l";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Повар";
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView ViewOrdernSS;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StatusFood;
        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}