namespace CafeBase
{
    partial class OpenDialogAdmin
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
            this.OpenAdminForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Zakazy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenAdminForm
            // 
            this.OpenAdminForm.Location = new System.Drawing.Point(12, 12);
            this.OpenAdminForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OpenAdminForm.Name = "OpenAdminForm";
            this.OpenAdminForm.Size = new System.Drawing.Size(163, 46);
            this.OpenAdminForm.TabIndex = 0;
            this.OpenAdminForm.Text = "Сотрудники";
            this.OpenAdminForm.UseVisualStyleBackColor = true;
            this.OpenAdminForm.Click += new System.EventHandler(this.OpenAdminForm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 64);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Смены";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(79, 199);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 28);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Zakazy
            // 
            this.Zakazy.Location = new System.Drawing.Point(13, 116);
            this.Zakazy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zakazy.Name = "Zakazy";
            this.Zakazy.Size = new System.Drawing.Size(163, 43);
            this.Zakazy.TabIndex = 3;
            this.Zakazy.Text = "Заказы";
            this.Zakazy.UseVisualStyleBackColor = true;
            this.Zakazy.Click += new System.EventHandler(this.Zakazy_Click);
            // 
            // OpenDialogAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 238);
            this.Controls.Add(this.Zakazy);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OpenAdminForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpenDialogAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OpenDialogAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenAdminForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Zakazy;
    }
}