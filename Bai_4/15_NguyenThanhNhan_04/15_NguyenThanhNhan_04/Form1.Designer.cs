namespace _15_NguyenThanhNhan_04
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
            this.dgvRDB = new System.Windows.Forms.DataGridView();
            this.lklRDS2GRID = new System.Windows.Forms.LinkLabel();
            this.lkl2XML_1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lklViewXML = new System.Windows.Forms.LinkLabel();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERT RDB DATA TO XML";
            // 
            // dgvRDB
            // 
            this.dgvRDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRDB.Location = new System.Drawing.Point(68, 172);
            this.dgvRDB.Name = "dgvRDB";
            this.dgvRDB.RowTemplate.Height = 24;
            this.dgvRDB.Size = new System.Drawing.Size(624, 205);
            this.dgvRDB.TabIndex = 1;
            // 
            // lklRDS2GRID
            // 
            this.lklRDS2GRID.AutoSize = true;
            this.lklRDS2GRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklRDS2GRID.Location = new System.Drawing.Point(83, 116);
            this.lklRDS2GRID.Name = "lklRDS2GRID";
            this.lklRDS2GRID.Size = new System.Drawing.Size(210, 29);
            this.lklRDS2GRID.TabIndex = 2;
            this.lklRDS2GRID.TabStop = true;
            this.lklRDS2GRID.Text = "SQLServer to Grid";
            this.lklRDS2GRID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklRDS2GRID_LinkClicked);
            // 
            // lkl2XML_1
            // 
            this.lkl2XML_1.AutoSize = true;
            this.lkl2XML_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl2XML_1.Location = new System.Drawing.Point(83, 414);
            this.lkl2XML_1.Name = "lkl2XML_1";
            this.lkl2XML_1.Size = new System.Drawing.Size(200, 29);
            this.lkl2XML_1.TabIndex = 3;
            this.lkl2XML_1.TabStop = true;
            this.lkl2XML_1.Text = "1-RDB 2 TO XML";
            this.lkl2XML_1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl2XML_1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(390, 414);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(200, 29);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "2-RDB 2 TO XML";
            // 
            // lklViewXML
            // 
            this.lklViewXML.AutoSize = true;
            this.lklViewXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklViewXML.Location = new System.Drawing.Point(642, 414);
            this.lklViewXML.Name = "lklViewXML";
            this.lklViewXML.Size = new System.Drawing.Size(261, 29);
            this.lklViewXML.TabIndex = 5;
            this.lklViewXML.TabStop = true;
            this.lklViewXML.Text = "View Result in Browser";
            this.lklViewXML.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklViewXML_LinkClicked);
            // 
            // dgvXML
            // 
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXML.Location = new System.Drawing.Point(68, 455);
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.RowTemplate.Height = 24;
            this.dgvXML.Size = new System.Drawing.Size(624, 132);
            this.dgvXML.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.dgvXML);
            this.Controls.Add(this.lklViewXML);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.lkl2XML_1);
            this.Controls.Add(this.lklRDS2GRID);
            this.Controls.Add(this.dgvRDB);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form 1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRDB;
        private System.Windows.Forms.LinkLabel lklRDS2GRID;
        private System.Windows.Forms.LinkLabel lkl2XML_1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lklViewXML;
        private System.Windows.Forms.DataGridView dgvXML;
    }
}

