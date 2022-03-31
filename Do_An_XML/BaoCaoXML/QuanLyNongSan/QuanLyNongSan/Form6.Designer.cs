namespace QuanLyNongSan
{
    partial class FormSaoLuuData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonXML_SQL = new System.Windows.Forms.Button();
            this.buttonKhoiPhuc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CSDL - SAO LƯU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyNongSan.Properties.Resources.bg04;
            this.pictureBox1.Image = global::QuanLyNongSan.Properties.Resources.image12;
            this.pictureBox1.Location = new System.Drawing.Point(0, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 243);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonXML_SQL
            // 
            this.buttonXML_SQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonXML_SQL.Location = new System.Drawing.Point(265, 85);
            this.buttonXML_SQL.Name = "buttonXML_SQL";
            this.buttonXML_SQL.Size = new System.Drawing.Size(267, 44);
            this.buttonXML_SQL.TabIndex = 2;
            this.buttonXML_SQL.Text = "Sao lưu (XML - mySQL)";
            this.buttonXML_SQL.UseVisualStyleBackColor = false;
            this.buttonXML_SQL.Click += new System.EventHandler(this.buttonXML_SQL_Click);
            // 
            // buttonKhoiPhuc
            // 
            this.buttonKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonKhoiPhuc.Location = new System.Drawing.Point(267, 227);
            this.buttonKhoiPhuc.Name = "buttonKhoiPhuc";
            this.buttonKhoiPhuc.Size = new System.Drawing.Size(263, 46);
            this.buttonKhoiPhuc.TabIndex = 4;
            this.buttonKhoiPhuc.Text = "Khôi phục dữ liệu";
            this.buttonKhoiPhuc.UseVisualStyleBackColor = false;
            this.buttonKhoiPhuc.Click += new System.EventHandler(this.buttonKhoiPhuc_Click);
            // 
            // FormSaoLuuData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyNongSan.Properties.Resources.bg04;
            this.ClientSize = new System.Drawing.Size(556, 300);
            this.Controls.Add(this.buttonKhoiPhuc);
            this.Controls.Add(this.buttonXML_SQL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSaoLuuData";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.FormSaoLuuData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonXML_SQL;
        private System.Windows.Forms.Button buttonKhoiPhuc;
    }
}