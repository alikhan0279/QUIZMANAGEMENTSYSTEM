namespace QUIZMANAGEMENTSYSTEM
{
    partial class AddorRemoveCourse
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtremovecourse = new System.Windows.Forms.TextBox();
            this.txtaddcourse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.REMOVE = new System.Windows.Forms.Button();
            this.ADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(162, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 273);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(345, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "ADD/ACTIVATE COURSE";
            // 
            // txtremovecourse
            // 
            this.txtremovecourse.Location = new System.Drawing.Point(474, 525);
            this.txtremovecourse.Name = "txtremovecourse";
            this.txtremovecourse.Size = new System.Drawing.Size(199, 20);
            this.txtremovecourse.TabIndex = 16;
            // 
            // txtaddcourse
            // 
            this.txtaddcourse.Location = new System.Drawing.Point(518, 94);
            this.txtaddcourse.Name = "txtaddcourse";
            this.txtaddcourse.Size = new System.Drawing.Size(199, 20);
            this.txtaddcourse.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(308, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "REMOVE/DEACTIVATE COURSE";
            // 
            // REMOVE
            // 
            this.REMOVE.BackColor = System.Drawing.Color.MediumOrchid;
            this.REMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REMOVE.ForeColor = System.Drawing.Color.White;
            this.REMOVE.Location = new System.Drawing.Point(451, 562);
            this.REMOVE.Name = "REMOVE";
            this.REMOVE.Size = new System.Drawing.Size(160, 30);
            this.REMOVE.TabIndex = 19;
            this.REMOVE.Text = "DEACTIVATE";
            this.REMOVE.UseVisualStyleBackColor = false;
            this.REMOVE.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.MediumOrchid;
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Location = new System.Drawing.Point(474, 135);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(160, 30);
            this.ADD.TabIndex = 20;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter Course to add/activate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Enter Course to deactivate";
            // 
            // AddorRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.REMOVE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaddcourse);
            this.Controls.Add(this.txtremovecourse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddorRemoveCourse";
            this.Text = "AddorRemoveCourse";
            this.Load += new System.EventHandler(this.AddorRemoveCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtremovecourse;
        private System.Windows.Forms.TextBox txtaddcourse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button REMOVE;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}