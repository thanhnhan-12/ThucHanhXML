
namespace WindowsFormsApp1.GUI
{
    partial class Main
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChỉSốĐiệnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnĐổiDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlSangXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlSangSqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.White;
            this.MenuStrip1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HệThốngToolStripMenuItem,
            this.QuảnLýToolStripMenuItem,
            this.TKToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.chuyểnĐổiDữLiệuToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1067, 31);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HệThốngToolStripMenuItem
            // 
            this.HệThốngToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.HệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThoátToolStripMenuItem});
            this.HệThốngToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.HệThốngToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.Hethong;
            this.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem";
            this.HệThốngToolStripMenuItem.ShowShortcutKeys = false;
            this.HệThốngToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.HệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // ThoátToolStripMenuItem
            // 
            this.ThoátToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ThoátToolStripMenuItem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.ThoátToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ThoátToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem";
            this.ThoátToolStripMenuItem.Size = new System.Drawing.Size(136, 28);
            this.ThoátToolStripMenuItem.Text = "Thoát";
            this.ThoátToolStripMenuItem.Click += new System.EventHandler(this.ThoátToolStripMenuItem_Click);
            // 
            // QuảnLýToolStripMenuItem
            // 
            this.QuảnLýToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.QuảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KháchHàngToolStripMenuItem,
            this.HóaĐơnToolStripMenuItem,
            this.ChỉSốĐiệnToolStripMenuItem1});
            this.QuảnLýToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.QuảnLýToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.quanly;
            this.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem";
            this.QuảnLýToolStripMenuItem.Size = new System.Drawing.Size(108, 27);
            this.QuảnLýToolStripMenuItem.Text = "Quản lý";
            this.QuảnLýToolStripMenuItem.Click += new System.EventHandler(this.QuảnLýToolStripMenuItem_Click);
            // 
            // KháchHàngToolStripMenuItem
            // 
            this.KháchHàngToolStripMenuItem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.KháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem";
            this.KháchHàngToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.KháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.KháchHàngToolStripMenuItem.Click += new System.EventHandler(this.KháchHàngToolStripMenuItem_Click);
            // 
            // HóaĐơnToolStripMenuItem
            // 
            this.HóaĐơnToolStripMenuItem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.HóaĐơnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem";
            this.HóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(184, 28);
            this.HóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.HóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.HóaĐơnToolStripMenuItem_Click);
            // 
            // ChỉSốĐiệnToolStripMenuItem1
            // 
            this.ChỉSốĐiệnToolStripMenuItem1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.ChỉSốĐiệnToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.ChỉSốĐiệnToolStripMenuItem1.Name = "ChỉSốĐiệnToolStripMenuItem1";
            this.ChỉSốĐiệnToolStripMenuItem1.Size = new System.Drawing.Size(184, 28);
            this.ChỉSốĐiệnToolStripMenuItem1.Text = "Chỉ số điện";
            this.ChỉSốĐiệnToolStripMenuItem1.Click += new System.EventHandler(this.ChỉSốĐiệnToolStripMenuItem1_Click);
            // 
            // TKToolStripMenuItem
            // 
            this.TKToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.TKToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.TKToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.thongke;
            this.TKToolStripMenuItem.Name = "TKToolStripMenuItem";
            this.TKToolStripMenuItem.Size = new System.Drawing.Size(120, 27);
            this.TKToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.trợGiúpToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.help;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(114, 27);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // chuyểnĐổiDữLiệuToolStripMenuItem
            // 
            this.chuyểnĐổiDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlSangXmlToolStripMenuItem,
            this.xmlSangSqlToolStripMenuItem});
            this.chuyểnĐổiDữLiệuToolStripMenuItem.Name = "chuyểnĐổiDữLiệuToolStripMenuItem";
            this.chuyểnĐổiDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(173, 27);
            this.chuyểnĐổiDữLiệuToolStripMenuItem.Text = "chuyển đổi dữ liệu";
            // 
            // sqlSangXmlToolStripMenuItem
            // 
            this.sqlSangXmlToolStripMenuItem.Name = "sqlSangXmlToolStripMenuItem";
            this.sqlSangXmlToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.sqlSangXmlToolStripMenuItem.Text = "sql sang xml";
            this.sqlSangXmlToolStripMenuItem.Click += new System.EventHandler(this.sqlSangXmlToolStripMenuItem_Click);
            // 
            // xmlSangSqlToolStripMenuItem
            // 
            this.xmlSangSqlToolStripMenuItem.Name = "xmlSangSqlToolStripMenuItem";
            this.xmlSangSqlToolStripMenuItem.Size = new System.Drawing.Size(216, 28);
            this.xmlSangSqlToolStripMenuItem.Text = "xml sang sql";
            this.xmlSangSqlToolStripMenuItem.Click += new System.EventHandler(this.xmlSangSqlToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Electric_Bill;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 613);
            this.Controls.Add(this.MenuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HệThốngToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ThoátToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem QuảnLýToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem KháchHàngToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HóaĐơnToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ChỉSốĐiệnToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem TKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnĐổiDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlSangXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xmlSangSqlToolStripMenuItem;
    }
}