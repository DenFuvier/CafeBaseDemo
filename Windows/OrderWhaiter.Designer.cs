namespace CafeBase.Windows
{
    partial class OrderWhaiter
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
            this.Ordernnn_View = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.TimeBox = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ordernnn_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Ordernnn_View
            // 
            this.Ordernnn_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Ordernnn_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ordernnn_View.Location = new System.Drawing.Point(12, 12);
            this.Ordernnn_View.Name = "Ordernnn_View";
            this.Ordernnn_View.ReadOnly = true;
            this.Ordernnn_View.RowHeadersWidth = 51;
            this.Ordernnn_View.Size = new System.Drawing.Size(776, 142);
            this.Ordernnn_View.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(695, 223);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(12, 160);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(124, 32);
            this.TimeBox.TabIndex = 3;
            this.TimeBox.Text = "Выбрать время : ";
            this.TimeBox.UseVisualStyleBackColor = true;
            this.TimeBox.Click += new System.EventHandler(this.TimeBox_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 198);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сбросить :";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 263);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ordernnn_View);
            this.Name = "Shifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifts";
            ((System.ComponentModel.ISupportInitialize)(this.Ordernnn_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Ordernnn_View;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button TimeBox;
        private System.Windows.Forms.Button btnReset;
    }
}