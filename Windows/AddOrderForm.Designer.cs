﻿namespace CafeBase.Windows
{
    partial class AddOrderForm
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
            this.PlusDish = new System.Windows.Forms.Button();
            this.exitthis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TableNumberBox = new System.Windows.Forms.ComboBox();
            this.ClientInt = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.NameBoxDish = new System.Windows.Forms.TextBox();
            this.DataBoxTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Jabw = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RadioOK = new System.Windows.Forms.RadioButton();
            this.RadioNOT = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // PlusDish
            // 
            this.PlusDish.Location = new System.Drawing.Point(668, 10);
            this.PlusDish.Margin = new System.Windows.Forms.Padding(2);
            this.PlusDish.Name = "PlusDish";
            this.PlusDish.Size = new System.Drawing.Size(104, 32);
            this.PlusDish.TabIndex = 0;
            this.PlusDish.Text = "Добавить заказ";
            this.PlusDish.UseVisualStyleBackColor = true;
            this.PlusDish.Click += new System.EventHandler(this.PlusDish_Click);
            // 
            // exitthis
            // 
            this.exitthis.Location = new System.Drawing.Point(702, 305);
            this.exitthis.Margin = new System.Windows.Forms.Padding(2);
            this.exitthis.Name = "exitthis";
            this.exitthis.Size = new System.Drawing.Size(70, 31);
            this.exitthis.TabIndex = 1;
            this.exitthis.Text = "Вернуться";
            this.exitthis.UseVisualStyleBackColor = true;
            this.exitthis.Click += new System.EventHandler(this.exitthis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите дату заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите номер столика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите количество клиентов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите количество блюд";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Выберите блюдо";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // TableNumberBox
            // 
            this.TableNumberBox.FormattingEnabled = true;
            this.TableNumberBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.TableNumberBox.Location = new System.Drawing.Point(206, 46);
            this.TableNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.TableNumberBox.Name = "TableNumberBox";
            this.TableNumberBox.Size = new System.Drawing.Size(433, 21);
            this.TableNumberBox.TabIndex = 9;
            // 
            // ClientInt
            // 
            this.ClientInt.FormattingEnabled = true;
            this.ClientInt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.ClientInt.Location = new System.Drawing.Point(206, 81);
            this.ClientInt.Margin = new System.Windows.Forms.Padding(2);
            this.ClientInt.Name = "ClientInt";
            this.ClientInt.Size = new System.Drawing.Size(433, 21);
            this.ClientInt.TabIndex = 10;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.comboBox3.Location = new System.Drawing.Point(206, 124);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(433, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // NameBoxDish
            // 
            this.NameBoxDish.Location = new System.Drawing.Point(206, 158);
            this.NameBoxDish.Margin = new System.Windows.Forms.Padding(2);
            this.NameBoxDish.Name = "NameBoxDish";
            this.NameBoxDish.Size = new System.Drawing.Size(433, 20);
            this.NameBoxDish.TabIndex = 12;
            // 
            // DataBoxTime
            // 
            this.DataBoxTime.Location = new System.Drawing.Point(206, 11);
            this.DataBoxTime.Margin = new System.Windows.Forms.Padding(2);
            this.DataBoxTime.Name = "DataBoxTime";
            this.DataBoxTime.Size = new System.Drawing.Size(433, 20);
            this.DataBoxTime.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Статус заказа:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 195);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 231);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(433, 20);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 262);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 20);
            this.textBox3.TabIndex = 17;
            // 
            // Jabw
            // 
            this.Jabw.AutoSize = true;
            this.Jabw.Location = new System.Drawing.Point(9, 231);
            this.Jabw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Jabw.Name = "Jabw";
            this.Jabw.Size = new System.Drawing.Size(58, 13);
            this.Jabw.TabIndex = 18;
            this.Jabw.Text = "Официант";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Повар";
            // 
            // RadioOK
            // 
            this.RadioOK.AutoSize = true;
            this.RadioOK.Location = new System.Drawing.Point(675, 71);
            this.RadioOK.Margin = new System.Windows.Forms.Padding(2);
            this.RadioOK.Name = "RadioOK";
            this.RadioOK.Size = new System.Drawing.Size(109, 17);
            this.RadioOK.TabIndex = 20;
            this.RadioOK.TabStop = true;
            this.RadioOK.Text = "Автозаполнение";
            this.RadioOK.UseVisualStyleBackColor = true;
            // 
            // RadioNOT
            // 
            this.RadioNOT.AutoSize = true;
            this.RadioNOT.Location = new System.Drawing.Point(675, 92);
            this.RadioNOT.Margin = new System.Windows.Forms.Padding(2);
            this.RadioNOT.Name = "RadioNOT";
            this.RadioNOT.Size = new System.Drawing.Size(72, 17);
            this.RadioNOT.TabIndex = 21;
            this.RadioNOT.TabStop = true;
            this.RadioNOT.Text = "Очистить";
            this.RadioNOT.UseVisualStyleBackColor = true;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 341);
            this.Controls.Add(this.RadioNOT);
            this.Controls.Add(this.RadioOK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Jabw);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataBoxTime);
            this.Controls.Add(this.NameBoxDish);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ClientInt);
            this.Controls.Add(this.TableNumberBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitthis);
            this.Controls.Add(this.PlusDish);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusDish;
        private System.Windows.Forms.Button exitthis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TableNumberBox;
        private System.Windows.Forms.ComboBox ClientInt;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox NameBoxDish;
        private System.Windows.Forms.TextBox DataBoxTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Jabw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton RadioOK;
        private System.Windows.Forms.RadioButton RadioNOT;
    }
}