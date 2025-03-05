namespace CafeBase
{
    partial class Waiter
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
            this.ViewOrdernS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.AddOrdxcen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernS)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1305, 410);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(103, 28);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ViewOrdernS
            // 
            this.ViewOrdernS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrdernS.Location = new System.Drawing.Point(12, 12);
            this.ViewOrdernS.Name = "ViewOrdernS";
            this.ViewOrdernS.ReadOnly = true;
            this.ViewOrdernS.RowHeadersWidth = 51;
            this.ViewOrdernS.RowTemplate.Height = 24;
            this.ViewOrdernS.Size = new System.Drawing.Size(1396, 239);
            this.ViewOrdernS.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать время заказа";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddOrdxcen
            // 
            this.AddOrdxcen.Location = new System.Drawing.Point(188, 257);
            this.AddOrdxcen.Name = "AddOrdxcen";
            this.AddOrdxcen.Size = new System.Drawing.Size(172, 35);
            this.AddOrdxcen.TabIndex = 3;
            this.AddOrdxcen.Text = "Добавить заказ";
            this.AddOrdxcen.UseVisualStyleBackColor = true;
            this.AddOrdxcen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 450);
            this.Controls.Add(this.AddOrdxcen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewOrdernS);
            this.Controls.Add(this.Exit);
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter";
            this.Load += new System.EventHandler(this.Waiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView ViewOrdernS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddOrdxcen;
    }
}