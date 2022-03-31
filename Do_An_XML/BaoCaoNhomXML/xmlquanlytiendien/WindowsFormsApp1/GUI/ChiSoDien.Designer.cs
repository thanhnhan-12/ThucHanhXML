
using System;

namespace WindowsFormsApp1.GUI
{
    partial class ChiSoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiSoDien));
            this.txtChisomoi = new System.Windows.Forms.TextBox();
            this.txtChisocu = new System.Windows.Forms.TextBox();
            this.txtMathang = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvChiSoDien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.ConvertSQL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoDien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChisomoi
            // 
            this.txtChisomoi.BackColor = System.Drawing.Color.White;
            this.txtChisomoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtChisomoi.Location = new System.Drawing.Point(461, 178);
            this.txtChisomoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChisomoi.Name = "txtChisomoi";
            this.txtChisomoi.Size = new System.Drawing.Size(188, 30);
            this.txtChisomoi.TabIndex = 75;
            // 
            // txtChisocu
            // 
            this.txtChisocu.BackColor = System.Drawing.Color.White;
            this.txtChisocu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtChisocu.Location = new System.Drawing.Point(461, 138);
            this.txtChisocu.Margin = new System.Windows.Forms.Padding(4);
            this.txtChisocu.Name = "txtChisocu";
            this.txtChisocu.Size = new System.Drawing.Size(188, 30);
            this.txtChisocu.TabIndex = 74;
            // 
            // txtMathang
            // 
            this.txtMathang.BackColor = System.Drawing.Color.White;
            this.txtMathang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMathang.Location = new System.Drawing.Point(461, 98);
            this.txtMathang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMathang.Name = "txtMathang";
            this.txtMathang.Size = new System.Drawing.Size(188, 30);
            this.txtMathang.TabIndex = 72;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.White;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaKH.Location = new System.Drawing.Point(461, 57);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(188, 30);
            this.txtMaKH.TabIndex = 68;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label5.Location = new System.Drawing.Point(257, 185);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(176, 27);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Chỉ số mới :";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label4.Location = new System.Drawing.Point(257, 142);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(176, 27);
            this.Label4.TabIndex = 70;
            this.Label4.Text = "Chỉ số cũ :";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label3.Location = new System.Drawing.Point(257, 101);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(176, 27);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Mã tháng :";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label2.Location = new System.Drawing.Point(257, 57);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(176, 27);
            this.Label2.TabIndex = 73;
            this.Label2.Text = "Mã khách hàng :";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvChiSoDien
            // 
            this.dgvChiSoDien.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvChiSoDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiSoDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvChiSoDien.Location = new System.Drawing.Point(47, 352);
            this.dgvChiSoDien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChiSoDien.Name = "dgvChiSoDien";
            this.dgvChiSoDien.RowHeadersWidth = 51;
            this.dgvChiSoDien.RowTemplate.Height = 24;
            this.dgvChiSoDien.Size = new System.Drawing.Size(683, 171);
            this.dgvChiSoDien.TabIndex = 85;
            this.dgvChiSoDien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridchisso_CellClick_1);
            this.dgvChiSoDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiSoDien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã tháng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chỉ số cũ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Chỉ số mới";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 86;
            this.label1.Text = "CHỈ SỐ ĐIỆN";
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.LightBlue;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnNhap.ForeColor = System.Drawing.Color.Navy;
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(91, 238);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(153, 66);
            this.btnNhap.TabIndex = 135;
            this.btnNhap.Text = "UPLOAD";
            this.btnNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightBlue;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.Navy;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(477, 238);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(157, 66);
            this.btnSua.TabIndex = 134;
            this.btnSua.Text = "EDIT";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Navy;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(677, 238);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 66);
            this.btnXoa.TabIndex = 133;
            this.btnXoa.Text = "DEL";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.LightBlue;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnTK.ForeColor = System.Drawing.Color.Navy;
            this.btnTK.Image = ((System.Drawing.Image)(resources.GetObject("btnTK.Image")));
            this.btnTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTK.Location = new System.Drawing.Point(761, 352);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(167, 66);
            this.btnTK.TabIndex = 132;
            this.btnTK.Text = "SEARCH";
            this.btnTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.Navy;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(280, 238);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(153, 66);
            this.btnThem.TabIndex = 131;
            this.btnThem.Text = "ADD";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.Color.Magenta;
            this.btnQuayLai.Location = new System.Drawing.Point(810, 24);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(118, 43);
            this.btnQuayLai.TabIndex = 136;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // ConvertSQL
            // 
            this.ConvertSQL.Location = new System.Drawing.Point(761, 448);
            this.ConvertSQL.Name = "ConvertSQL";
            this.ConvertSQL.Size = new System.Drawing.Size(167, 49);
            this.ConvertSQL.TabIndex = 137;
            this.ConvertSQL.Text = "SQL";
            this.ConvertSQL.UseVisualStyleBackColor = true;
            this.ConvertSQL.Click += new System.EventHandler(this.ConvertSQL_Click);
            // 
            // ChiSoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.ClientSize = new System.Drawing.Size(956, 560);
            this.Controls.Add(this.ConvertSQL);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChiSoDien);
            this.Controls.Add(this.txtChisomoi);
            this.Controls.Add(this.txtChisocu);
            this.Controls.Add(this.txtMathang);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChiSoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiSoDien";
            this.Load += new System.EventHandler(this.ChiSoDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiSoDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      



        #endregion
        internal System.Windows.Forms.TextBox txtChisomoi;
        internal System.Windows.Forms.TextBox txtChisocu;
        internal System.Windows.Forms.TextBox txtMathang;
        internal System.Windows.Forms.TextBox txtMaKH;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DataGridView dgvChiSoDien;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnNhap;
        internal System.Windows.Forms.Button btnSua;
        internal System.Windows.Forms.Button btnXoa;
        internal System.Windows.Forms.Button btnTK;
        internal System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button ConvertSQL;
    }
}