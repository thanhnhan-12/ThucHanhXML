namespace _15_NguyenThanhNhan_04
{
    partial class DashBoard
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
            this.lklTestStart = new System.Windows.Forms.LinkLabel();
            this.lkStudent = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // lklTestStart
            // 
            this.lklTestStart.AutoSize = true;
            this.lklTestStart.Location = new System.Drawing.Point(116, 100);
            this.lklTestStart.Name = "lklTestStart";
            this.lklTestStart.Size = new System.Drawing.Size(100, 17);
            this.lklTestStart.TabIndex = 1;
            this.lklTestStart.TabStop = true;
            this.lklTestStart.Text = "Link Test Start";
            this.lklTestStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklTestStart_LinkClicked);
            // 
            // lkStudent
            // 
            this.lkStudent.AutoSize = true;
            this.lkStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkStudent.Location = new System.Drawing.Point(357, 202);
            this.lkStudent.Name = "lkStudent";
            this.lkStudent.Size = new System.Drawing.Size(225, 29);
            this.lkStudent.TabIndex = 2;
            this.lkStudent.TabStop = true;
            this.lkStudent.Text = "Danh sách sinh viên";
            this.lkStudent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkStudent_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_15_NguyenThanhNhan_04.Properties.Resources.dashboard;
            this.pictureBox1.Location = new System.Drawing.Point(46, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(598, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lkStudent);
            this.Controls.Add(this.lklTestStart);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklTestStart;
        private System.Windows.Forms.LinkLabel lkStudent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}