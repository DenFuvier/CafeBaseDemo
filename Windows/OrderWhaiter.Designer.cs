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
            this.Ordernnn_View.Location = new System.Drawing.Point(16, 15);
            this.Ordernnn_View.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ordernnn_View.Name = "Ordernnn_View";
            this.Ordernnn_View.ReadOnly = true;
            this.Ordernnn_View.RowHeadersWidth = 51;
            this.Ordernnn_View.Size = new System.Drawing.Size(1197, 175);
            this.Ordernnn_View.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1088, 277);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 36);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Вернуться";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(16, 197);
            this.TimeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(165, 39);
            this.TimeBox.TabIndex = 3;
            this.TimeBox.Text = "Выбрать время : ";
            this.TimeBox.UseVisualStyleBackColor = true;
            this.TimeBox.Click += new System.EventHandler(this.TimeBox_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 244);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Сбросить :";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // OrderWhaiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1225, 324);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Ordernnn_View);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderWhaiter";
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