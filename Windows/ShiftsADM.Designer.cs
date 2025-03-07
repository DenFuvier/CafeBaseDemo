namespace CafeBase.Trash
{
    partial class ShiftsADM
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
            this.AdminViewShifts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminViewShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminViewShifts
            // 
            this.AdminViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminViewShifts.Location = new System.Drawing.Point(12, 12);
            this.AdminViewShifts.Name = "AdminViewShifts";
            this.AdminViewShifts.RowHeadersWidth = 51;
            this.AdminViewShifts.RowTemplate.Height = 24;
            this.AdminViewShifts.Size = new System.Drawing.Size(776, 150);
            this.AdminViewShifts.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вернуться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить смену";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ShiftsADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminViewShifts);
            this.Name = "ShiftsADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShiftsADM";
            ((System.ComponentModel.ISupportInitialize)(this.AdminViewShifts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminViewShifts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}