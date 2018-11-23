namespace newConsoleApp1
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
            this.hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.db = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.db_status = new System.Windows.Forms.Label();
            this.tables = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(697, 28);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(75, 23);
            this.hide.TabIndex = 0;
            this.hide.Text = "Close";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.db);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 147);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL Connector";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(103, 87);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 6;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(103, 57);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(100, 20);
            this.login.TabIndex = 5;
            this.login.Text = "root";
            // 
            // db
            // 
            this.db.Location = new System.Drawing.Point(103, 22);
            this.db.Name = "db";
            this.db.Size = new System.Drawing.Size(100, 20);
            this.db.TabIndex = 4;
            this.db.Text = " localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // dbs
            // 
            this.dbs.FormattingEnabled = true;
            this.dbs.Location = new System.Drawing.Point(365, 40);
            this.dbs.Name = "dbs";
            this.dbs.Size = new System.Drawing.Size(120, 95);
            this.dbs.TabIndex = 4;
            this.dbs.SelectedIndexChanged += new System.EventHandler(this.dbs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select DB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // db_status
            // 
            this.db_status.AutoSize = true;
            this.db_status.Location = new System.Drawing.Point(425, 163);
            this.db_status.Name = "db_status";
            this.db_status.Size = new System.Drawing.Size(0, 13);
            this.db_status.TabIndex = 7;
            // 
            // tables
            // 
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(508, 40);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(120, 95);
            this.tables.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tables";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Show content";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 283);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.db_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hide);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox db;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox dbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label db_status;
        private System.Windows.Forms.ListBox tables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}