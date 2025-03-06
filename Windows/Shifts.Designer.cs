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
            ((System.ComponentModel.ISupportInitialize)(this.Shift_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Shift_View
            // 
            this.Shift_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shift_View.Location = new System.Drawing.Point(12, 12);
            this.Shift_View.Name = "Shift_View";
            this.Shift_View.Size = new System.Drawing.Size(776, 142);
            this.Shift_View.TabIndex = 0;
            // 
            // Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shift_View);
            this.Name = "Shifts";
            this.Text = "Shifts";
            ((System.ComponentModel.ISupportInitialize)(this.Shift_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Shift_View;
    }
}