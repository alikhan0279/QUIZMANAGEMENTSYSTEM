namespace QUIZMANAGEMENTSYSTEM
{
    partial class QuizOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizOption));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cmbselectcourse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(357, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(363, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // cmbselectcourse
            // 
            this.cmbselectcourse.AutoCompleteCustomSource.AddRange(new string[] {
            "Teacher",
            "Student"});
            this.cmbselectcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbselectcourse.FormattingEnabled = true;
            this.cmbselectcourse.Location = new System.Drawing.Point(492, 130);
            this.cmbselectcourse.Name = "cmbselectcourse";
            this.cmbselectcourse.Size = new System.Drawing.Size(168, 24);
            this.cmbselectcourse.TabIndex = 8;
            this.cmbselectcourse.SelectedIndexChanged += new System.EventHandler(this.cmbselectcourse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Course";
            // 
            // btnlogins
            // 
            this.btnlogins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogins.ForeColor = System.Drawing.Color.White;
            this.btnlogins.Location = new System.Drawing.Point(445, 201);
            this.btnlogins.Name = "btnlogins";
            this.btnlogins.Size = new System.Drawing.Size(138, 44);
            this.btnlogins.TabIndex = 11;
            this.btnlogins.Text = "Attempt Quiz";
            this.btnlogins.UseVisualStyleBackColor = false;
            this.btnlogins.Click += new System.EventHandler(this.btnlogins_Click);
            // 
            // QuizOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 480);
            this.Controls.Add(this.btnlogins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbselectcourse);
            this.Controls.Add(this.pictureBox2);
            this.Name = "QuizOption";
            this.Text = "QuizOption";
            this.Load += new System.EventHandler(this.QuizOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogins;
        public System.Windows.Forms.ComboBox cmbselectcourse;
    }
}