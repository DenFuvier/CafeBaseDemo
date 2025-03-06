﻿namespace CafeBase
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
            this.Exit.Location = new System.Drawing.Point(979, 333);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(77, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ViewOrdernS
            // 
            this.ViewOrdernS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewOrdernS.Location = new System.Drawing.Point(9, 10);
            this.ViewOrdernS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewOrdernS.Name = "ViewOrdernS";
            this.ViewOrdernS.ReadOnly = true;
            this.ViewOrdernS.RowHeadersWidth = 51;
            this.ViewOrdernS.RowTemplate.Height = 24;
            this.ViewOrdernS.Size = new System.Drawing.Size(1047, 194);
            this.ViewOrdernS.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 209);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать время заказа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrdxcen
            // 
            this.AddOrdxcen.Location = new System.Drawing.Point(141, 209);
            this.AddOrdxcen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddOrdxcen.Name = "AddOrdxcen";
            this.AddOrdxcen.Size = new System.Drawing.Size(129, 28);
            this.AddOrdxcen.TabIndex = 3;
            this.AddOrdxcen.Text = "Добавить заказ";
            this.AddOrdxcen.UseVisualStyleBackColor = true;
            this.AddOrdxcen.Click += new System.EventHandler(this.button2_Click);
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 366);
            this.Controls.Add(this.AddOrdxcen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ViewOrdernS);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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