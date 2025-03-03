namespace CafeBase
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogIN = new System.Windows.Forms.Button();
            this.Login1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OFF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIN
            // 
            this.LogIN.Location = new System.Drawing.Point(291, 84);
            this.LogIN.Name = "LogIN";
            this.LogIN.Size = new System.Drawing.Size(86, 30);
            this.LogIN.TabIndex = 0;
            this.LogIN.Text = "Войти";
            this.LogIN.UseVisualStyleBackColor = true;
            this.LogIN.Click += new System.EventHandler(this.LogIN_Click);
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(97, 9);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(190, 22);
            this.Login1.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(97, 37);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(190, 22);
            this.Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(5, 115);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(100, 28);
            this.OFF.TabIndex = 5;
            this.OFF.Text = "Закрыть";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 155);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.LogIN);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIN;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login1;
        private System.Windows.Forms.Button OFF;
    }
}

