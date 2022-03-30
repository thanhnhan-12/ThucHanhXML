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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.cboCCode = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listCustomerToolStripMenuItem,
            this.listItemsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listCustomerToolStripMenuItem
            // 
            this.listCustomerToolStripMenuItem.Name = "listCustomerToolStripMenuItem";
            this.listCustomerToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.listCustomerToolStripMenuItem.Text = "List Customer";
            this.listCustomerToolStripMenuItem.Click += new System.EventHandler(this.listCustomerToolStripMenuItem_Click);
            // 
            // listItemsToolStripMenuItem
            // 
            this.listItemsToolStripMenuItem.Name = "listItemsToolStripMenuItem";
            this.listItemsToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.listItemsToolStripMenuItem.Text = "List Items";
            this.listItemsToolStripMenuItem.Click += new System.EventHandler(this.listItemsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 24);
            this.toolStripMenuItem1.Text = "31/10/2021";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "OrderNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Code";
            // 
            // cboOrder
            // 
            this.cboOrder.FormattingEnabled = true;
            this.cboOrder.Location = new System.Drawing.Point(105, 103);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(198, 24);
            this.cboOrder.TabIndex = 4;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged);
            // 
            // cboCCode
            // 
            this.cboCCode.FormattingEnabled = true;
            this.cboCCode.Location = new System.Drawing.Point(463, 102);
            this.cboCCode.Name = "cboCCode";
            this.cboCCode.Size = new System.Drawing.Size(185, 24);
            this.cboCCode.TabIndex = 5;
            this.cboCCode.SelectedIndexChanged += new System.EventHandler(this.cboCCode_SelectedIndexChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(708, 109);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(46, 17);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(157, 448);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label4";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(18, 161);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(630, 267);
            this.dgvData.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 523);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cboCCode);
            this.Controls.Add(this.cboOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOrder;
        private System.Windows.Forms.ComboBox cboCCode;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

