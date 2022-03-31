using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNongSan
{
    public partial class FormSaoLuuData : Form
    {
        public FormSaoLuuData()
        {
            InitializeComponent();
        }

        private void buttonXML_SQL_Click(object sender, EventArgs e)
        {
            BackUp bk = new BackUp();
            bk.BackUpData();
            MessageBox.Show("Đã sao lưu lên máy chủ","Thông Báo");
        }

        private void buttonKhoiPhuc_Click(object sender, EventArgs e)
        {
            Restore rs = new Restore();
            rs.RestoreData();
            MessageBox.Show("Đã Tải Dữ Liệu Từ Máy Chủ Về", "Thông Báo");
        }

        private void FormSaoLuuData_Load(object sender, EventArgs e)
        {

        }

        private void buttonSQL_XML_Click(object sender, EventArgs e)
        {

        }
    }
}
