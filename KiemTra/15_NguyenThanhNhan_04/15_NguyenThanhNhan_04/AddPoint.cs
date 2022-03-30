using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace _15_NguyenThanhNhan_04
{
    public partial class AddPoint : Form
    {
        public XmlElement student = null;
        String path = "student.xml";
        String code = "";
        XDocument xdoc;
        XmlDocument xmlDoc = new XmlDocument();

        public AddPoint()
        {
            InitializeComponent();
        }

        private void AddPoint_Load(object sender, EventArgs e)
        {
            student = Form1.student; // lấy XmlElement bên lớp Form1
            lblInfo.Text = Form1.sname;
            code = Form1.scode;
            InitCCode();
        }

        void InitCCode()
        {
            xdoc = XDocument.Load(path);
            var qr = (from XElement e in xdoc.Descendants("course")
                      orderby e.Attribute("code").Value descending
                      select e.Attribute("code").Value).Distinct();
            foreach (String str in qr)
            {
                cboCode.Items.Add(str);
            }
        }
        string findnameHP(String code)
        {
            string nameHP = "";
            // Trả về ChildNodes của student có mã số code
            // để in ra điểm các môn học của sinh viên này

            xmlDoc.Load(path);
            XmlNodeList list = xmlDoc.GetElementsByTagName("course");
            foreach (XmlElement x in list)
            {
                if (x.GetAttribute("code") == code)
                {
                    nameHP = x.GetAttribute("name");
                    break;
                }
            }
            return nameHP;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlElement course = Form1.xmlDoc.CreateElement("course");
            course.SetAttribute("code", cboCode.Text);
            course.SetAttribute("name", txtName.Text);
            course.SetAttribute("credit", txtCredit.Text);
            course.SetAttribute("point", txtPoint.Text);
            try
            {
                student.AppendChild(course);
                Form1.xmlDoc.Save(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Inserted!\nClick button Course to view result");
           
            this.Close();
        }

        private void cboCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = findnameHP(cboCode.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
