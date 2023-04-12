namespace DataManager
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DTime = new System.Windows.Forms.Label();
            this.DpNumber = new System.Windows.Forms.Label();
            this.DAdress = new System.Windows.Forms.Label();
            this.DGender = new System.Windows.Forms.Label();
            this.DAge = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Saving = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.FName);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Adress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Age);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 648);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Box";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Registration Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 502);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 35);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(227, 123);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(286, 35);
            this.FName.TabIndex = 12;
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "M",
            "F",
            "O"});
            this.Gender.Location = new System.Drawing.Point(227, 271);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 35);
            this.Gender.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 15;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(227, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone Number";
            // 
            // PNumber
            // 
            this.PNumber.Location = new System.Drawing.Point(227, 431);
            this.PNumber.Name = "PNumber";
            this.PNumber.Size = new System.Drawing.Size(287, 35);
            this.PNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adress";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(227, 349);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(287, 35);
            this.Adress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(227, 193);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(287, 35);
            this.Age.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.DTime);
            this.groupBox2.Controls.Add(this.DpNumber);
            this.groupBox2.Controls.Add(this.DAdress);
            this.groupBox2.Controls.Add(this.DGender);
            this.groupBox2.Controls.Add(this.DAge);
            this.groupBox2.Controls.Add(this.DName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Saving);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 648);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Management";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(38, 68);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 28);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show";
            // 
            // DTime
            // 
            this.DTime.AutoSize = true;
            this.DTime.Location = new System.Drawing.Point(96, 446);
            this.DTime.Name = "DTime";
            this.DTime.Size = new System.Drawing.Size(0, 28);
            this.DTime.TabIndex = 26;
            // 
            // DpNumber
            // 
            this.DpNumber.AutoSize = true;
            this.DpNumber.Location = new System.Drawing.Point(216, 591);
            this.DpNumber.Name = "DpNumber";
            this.DpNumber.Size = new System.Drawing.Size(0, 28);
            this.DpNumber.TabIndex = 25;
            // 
            // DAdress
            // 
            this.DAdress.AutoSize = true;
            this.DAdress.Location = new System.Drawing.Point(216, 562);
            this.DAdress.Name = "DAdress";
            this.DAdress.Size = new System.Drawing.Size(0, 28);
            this.DAdress.TabIndex = 24;
            // 
            // DGender
            // 
            this.DGender.AutoSize = true;
            this.DGender.Location = new System.Drawing.Point(216, 534);
            this.DGender.Name = "DGender";
            this.DGender.Size = new System.Drawing.Size(0, 28);
            this.DGender.TabIndex = 23;
            // 
            // DAge
            // 
            this.DAge.AutoSize = true;
            this.DAge.Location = new System.Drawing.Point(216, 502);
            this.DAge.Name = "DAge";
            this.DAge.Size = new System.Drawing.Size(0, 28);
            this.DAge.TabIndex = 22;
            // 
            // DName
            // 
            this.DName.AutoSize = true;
            this.DName.Location = new System.Drawing.Point(216, 474);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(0, 28);
            this.DName.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 662);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Registration Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Personal Profile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone Number";
            // 
            // Saving
            // 
            this.Saving.Location = new System.Drawing.Point(242, 58);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(124, 44);
            this.Saving.TabIndex = 8;
            this.Saving.Text = "button7";
            this.Saving.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 562);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Adress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 28);
            this.label11.TabIndex = 17;
            this.label11.Text = "Gender";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(221, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(145, 35);
            this.button6.TabIndex = 6;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Age";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 35);
            this.textBox3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 474);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 28);
            this.label13.TabIndex = 15;
            this.label13.Text = "Full Name";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(15, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Clean";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(221, 193);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(371, 191);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DETAILS";
            this.columnHeader1.Width = 155;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 672);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Button Saving;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DTime;
        private System.Windows.Forms.Label DpNumber;
        private System.Windows.Forms.Label DAdress;
        private System.Windows.Forms.Label DGender;
        private System.Windows.Forms.Label DAge;
        private System.Windows.Forms.Label DName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

