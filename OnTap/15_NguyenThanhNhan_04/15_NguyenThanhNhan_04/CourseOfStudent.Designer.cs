namespace _15_NguyenThanhNhan_04
{
    partial class CourseOfStudent
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccumulation = new System.Windows.Forms.Label();
            this.dgvPoint = new System.Windows.Forms.DataGridView();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(174, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(53, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng";
            // 
            // lblAccumulation
            // 
            this.lblAccumulation.AutoSize = true;
            this.lblAccumulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumulation.Location = new System.Drawing.Point(174, 427);
            this.lblAccumulation.Name = "lblAccumulation";
            this.lblAccumulation.Size = new System.Drawing.Size(53, 20);
            this.lblAccumulation.TabIndex = 3;
            this.lblAccumulation.Text = "label4";
            // 
            // dgvPoint
            // 
            this.dgvPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoint.Location = new System.Drawing.Point(46, 122);
            this.dgvPoint.Name = "dgvPoint";
            this.dgvPoint.RowTemplate.Height = 24;
            this.dgvPoint.Size = new System.Drawing.Size(676, 266);
            this.dgvPoint.TabIndex = 4;
            // 
            // btnViewResult
            // 
            this.btnViewResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResult.Location = new System.Drawing.Point(598, 40);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(124, 37);
            this.btnViewResult.TabIndex = 5;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // CourseOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.dgvPoint);
            this.Controls.Add(this.lblAccumulation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Name = "CourseOfStudent";
            this.Text = "CourseOfStudent";
            this.Load += new System.EventHandler(this.CourseOfStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAccumulation;
        private System.Windows.Forms.DataGridView dgvPoint;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Label label2;
    }
}