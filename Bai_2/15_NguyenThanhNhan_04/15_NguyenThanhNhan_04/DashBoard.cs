using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace _15_NguyenThanhNhan_04
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void TestProcessStart()
        {
            // Thử nghiệm mở tệp HTML, XML với browser
            //string path = "../data/student.xml";
            string pathStudent = Application.StartupPath + "\\data\\student.xml";
            var fullpath = Path.GetFullPath(pathStudent);
            Process.Start("IExplore.exe",fullpath);
            //Process.Start("firefox.exe", fullpath);
            //Process.Start("Explorer.exe", fullpath);
        }

        private void lklTestStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestProcessStart();
        }

        private void lkStudent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student stu = new Student();
            
            stu.Show();
        }
    }
}
