
namespace QUIZMANAGEMENTSYSTEM
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusernamet = new System.Windows.Forms.TextBox();
            this.cmbselectuser = new System.Windows.Forms.ComboBox();
            this.panelt = new System.Windows.Forms.Panel();
            this.btnsignupt = new System.Windows.Forms.Button();
            this.btnlogint = new System.Windows.Forms.Button();
            this.txtpasswordt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelst = new System.Windows.Forms.Panel();
            this.btnsignups = new System.Windows.Forms.Button();
            this.btnlogins = new System.Windows.Forms.Button();
            this.txtpasswords = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtrollnos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelt.SuspendLayout();
            this.panelst.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(380, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUIZ MANAGEMENT SYSTEM";
            // 
            // txtusernamet
            // 
            this.txtusernamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusernamet.Location = new System.Drawing.Point(167, 117);
            this.txtusernamet.Name = "txtusernamet";
            this.txtusernamet.Size = new System.Drawing.Size(195, 24);
            this.txtusernamet.TabIndex = 1;
            // 
            // cmbselectuser
            // 
            this.cmbselectuser.AutoCompleteCustomSource.AddRange(new string[] {
            "Teacher",
            "Student"});
            this.cmbselectuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselectuser.FormattingEnabled = true;
            this.cmbselectuser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmbselectuser.Location = new System.Drawing.Point(627, 165);
            this.cmbselectuser.Name = "cmbselectuser";
            this.cmbselectuser.Size = new System.Drawing.Size(168, 24);
            this.cmbselectuser.TabIndex = 2;
            this.cmbselectuser.SelectedIndexChanged += new System.EventHandler(this.cmbselectuser_SelectedIndexChanged);
            // 
            // panelt
            // 
            this.panelt.Controls.Add(this.btnsignupt);
            this.panelt.Controls.Add(this.btnlogint);
            this.panelt.Controls.Add(this.txtpasswordt);
            this.panelt.Controls.Add(this.label4);
            this.panelt.Controls.Add(this.label5);
            this.panelt.Controls.Add(this.label3);
            this.panelt.Controls.Add(this.txtusernamet);
            this.panelt.Location = new System.Drawing.Point(433, 205);
            this.panelt.Name = "panelt";
            this.panelt.Size = new System.Drawing.Size(431, 379);
            this.panelt.TabIndex = 3;
            // 
            // btnsignupt
            // 
            this.btnsignupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsignupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignupt.ForeColor = System.Drawing.Color.White;
            this.btnsignupt.Location = new System.Drawing.Point(154, 313);
            this.btnsignupt.Name = "btnsignupt";
            this.btnsignupt.Size = new System.Drawing.Size(138, 44);
            this.btnsignupt.TabIndex = 11;
            this.btnsignupt.Text = "SIGN UP";
            this.btnsignupt.UseVisualStyleBackColor = false;
            this.btnsignupt.Click += new System.EventHandler(this.btnsignupt_Click);
            // 
            // btnlogint
            // 
            this.btnlogint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogint.ForeColor = System.Drawing.Color.White;
            this.btnlogint.Location = new System.Drawing.Point(154, 234);
            this.btnlogint.Name = "btnlogint";
            this.btnlogint.Size = new System.Drawing.Size(138, 44);
            this.btnlogint.TabIndex = 10;
            this.btnlogint.Text = "LOGIN";
            this.btnlogint.UseVisualStyleBackColor = false;
            this.btnlogint.Click += new System.EventHandler(this.btnlogint_Click);
            // 
            // txtpasswordt
            // 
            this.txtpasswordt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswordt.Location = new System.Drawing.Point(167, 162);
            this.txtpasswordt.Name = "txtpasswordt";
            this.txtpasswordt.PasswordChar = '*';
            this.txtpasswordt.Size = new System.Drawing.Size(195, 24);
            this.txtpasswordt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(129, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teacher Login ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select User Type";
            // 
            // panelst
            // 
            this.panelst.Controls.Add(this.btnsignups);
            this.panelst.Controls.Add(this.btnlogins);
            this.panelst.Controls.Add(this.txtpasswords);
            this.panelst.Controls.Add(this.label6);
            this.panelst.Controls.Add(this.label7);
            this.panelst.Controls.Add(this.label8);
            this.panelst.Controls.Add(this.txtrollnos);
            this.panelst.Location = new System.Drawing.Point(430, 202);
            this.panelst.Name = "panelst";
            this.panelst.Size = new System.Drawing.Size(431, 379);
            this.panelst.TabIndex = 12;
            // 
            // btnsignups
            // 
            this.btnsignups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnsignups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignups.ForeColor = System.Drawing.Color.White;
            this.btnsignups.Location = new System.Drawing.Point(154, 313);
            this.btnsignups.Name = "btnsignups";
            this.btnsignups.Size = new System.Drawing.Size(138, 44);
            this.btnsignups.TabIndex = 11;
            this.btnsignups.Text = "SIGN UP";
            this.btnsignups.UseVisualStyleBackColor = false;
            this.btnsignups.Click += new System.EventHandler(this.btnsignups_Click);
            // 
            // btnlogins
            // 
            this.btnlogins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogins.ForeColor = System.Drawing.Color.White;
            this.btnlogins.Location = new System.Drawing.Point(154, 234);
            this.btnlogins.Name = "btnlogins";
            this.btnlogins.Size = new System.Drawing.Size(138, 44);
            this.btnlogins.TabIndex = 10;
            this.btnlogins.Text = "LOGIN";
            this.btnlogins.UseVisualStyleBackColor = false;
            this.btnlogins.Click += new System.EventHandler(this.btnlogins_Click);
            // 
            // txtpasswords
            // 
            this.txtpasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasswords.Location = new System.Drawing.Point(167, 162);
            this.txtpasswords.Name = "txtpasswords";
            this.txtpasswords.PasswordChar = '*';
            this.txtpasswords.Size = new System.Drawing.Size(195, 24);
            this.txtpasswords.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Roll no";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(140, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 5;
            this.label8.Text = "Student Login ";
            // 
            // txtrollnos
            // 
            this.txtrollnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrollnos.Location = new System.Drawing.Point(167, 117);
            this.txtrollnos.Name = "txtrollnos";
            this.txtrollnos.Size = new System.Drawing.Size(195, 24);
            this.txtrollnos.TabIndex = 1;
            this.txtrollnos.TextChanged += new System.EventHandler(this.txtrollnos_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(587, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "QUIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1153, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelt);
            this.Controls.Add(this.cmbselectuser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelt.ResumeLayout(false);
            this.panelt.PerformLayout();
            this.panelst.ResumeLayout(false);
            this.panelst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusernamet;
        private System.Windows.Forms.ComboBox cmbselectuser;
        private System.Windows.Forms.Panel panelt;
        private System.Windows.Forms.Button btnsignupt;
        private System.Windows.Forms.Button btnlogint;
        private System.Windows.Forms.TextBox txtpasswordt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelst;
        private System.Windows.Forms.Button btnsignups;
        private System.Windows.Forms.Button btnlogins;
        private System.Windows.Forms.TextBox txtpasswords;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtrollnos;
        private System.Windows.Forms.Button button1;
    }
}

