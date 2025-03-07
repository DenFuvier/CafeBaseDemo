namespace CafeBase.Windows
{
    partial class Shifts
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
            this.Shift_View = new System.Windows.Forms.DataGridView();
            this.UserIDView = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Shift_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIDView)).BeginInit();
            this.SuspendLayout();
            // 
            // Shift_View
            // 
            this.Shift_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shift_View.Location = new System.Drawing.Point(16, 15);
            this.Shift_View.Margin = new System.Windows.Forms.Padding(4);
            this.Shift_View.Name = "Shift_View";
            this.Shift_View.ReadOnly = true;
            this.Shift_View.RowHeadersWidth = 51;
            this.Shift_View.Size = new System.Drawing.Size(1035, 175);
            this.Shift_View.TabIndex = 0;
            // 
            // UserIDView
            // 
            this.UserIDView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserIDView.Location = new System.Drawing.Point(16, 197);
            this.UserIDView.Name = "UserIDView";
            this.UserIDView.ReadOnly = true;
            this.UserIDView.RowHeadersWidth = 51;
            this.UserIDView.RowTemplate.Height = 24;
            this.UserIDView.Size = new System.Drawing.Size(1039, 150);
            this.UserIDView.TabIndex = 1;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(929, 506);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(126, 36);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UserIDView);
            this.Controls.Add(this.Shift_View);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Shifts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shifts";
            ((System.ComponentModel.ISupportInitialize)(this.Shift_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIDView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Shift_View;
        private System.Windows.Forms.DataGridView UserIDView;
        private System.Windows.Forms.Button Exit;
    }
}