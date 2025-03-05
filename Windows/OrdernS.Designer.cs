namespace CafeBase
{
    partial class OrdernS
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
            this.ViewOrdernS = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernS)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewOrdernS
            // 
            this.ViewOrdernS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrdernS.Location = new System.Drawing.Point(12, 12);
            this.ViewOrdernS.Name = "ViewOrdernS";
            this.ViewOrdernS.ReadOnly = true;
            this.ViewOrdernS.RowHeadersWidth = 51;
            this.ViewOrdernS.RowTemplate.Height = 24;
            this.ViewOrdernS.Size = new System.Drawing.Size(1464, 360);
            this.ViewOrdernS.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1368, 438);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 38);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // OrdernS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 488);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ViewOrdernS);
            this.Name = "OrdernS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdernS";
            ((System.ComponentModel.ISupportInitialize)(this.ViewOrdernS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewOrdernS;
        private System.Windows.Forms.Button Exit;
    }
}