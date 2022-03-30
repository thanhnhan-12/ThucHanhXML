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

namespace _15_NguyenThanhNhan_04
{
    public partial class CourseOfStudent : Form
    {
        String code;
        String path = "student.xml";
        XmlDocument xmlDoc = new XmlDocument();

        public CourseOfStudent()
        {
            InitializeComponent();
        }

        private void CourseOfStudent_Load(object sender, EventArgs e)
        {
            lblInfo.Text = Form1.scode + ", " + Form1.sname;
            code = Form1.scode;
        }

        XmlNodeList findCourse(String code)
        {
            // Trả về ChildNodes của student có mã số code
            // để in ra điểm các môn học của sinh viên này
            XmlNodeList result = null;
            xmlDoc.Load(path);
            XmlNodeList list = xmlDoc.GetElementsByTagName("student");
            foreach (XmlElement x in list)
            {
                if (x.GetAttribute("code") == code)
                {
                    result = x.ChildNodes;
                    break;
                }
            }
            return result;
        }

        private void listCourse()
        {
            // khởi tạo
            dgvPoint.Rows.Clear();
            dgvPoint.ColumnCount = 3;
            dgvPoint.Columns[0].Name = "CourseName";
            dgvPoint.Columns[0].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPoint.Columns[0].HeaderCell
            .Style.Alignment =
           DataGridViewContentAlignment.MiddleRight;
            dgvPoint.Columns[0].Width = 150;
            dgvPoint.Columns[1].Name = "redit";
            dgvPoint.Columns[1].Width = 80;
            dgvPoint.Columns[2].Name = "Point";
            dgvPoint.Columns[2].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPoint.Columns[2].HeaderCell
            .Style.Alignment =
           DataGridViewContentAlignment.MiddleRight;
            dgvPoint.Columns[2].Width = 85;
            // Hiển thị kết quả học tập trong grid
            String name;
            int credit, point, totalCredit = 0;
            float sumPoint = 0;
            XmlNodeList list = findCourse(code);
            foreach (XmlElement x in list)
            {
                name = x.GetAttribute("name");
                credit = Convert.ToInt16(x.GetAttribute("credit"));
                point = Convert.ToInt16(x.GetAttribute("point"));
                dgvPoint.Rows.Add(name, credit, point);
                totalCredit += credit;
                sumPoint += (credit * point);
            }
            lblAccumulation.Text = Convert.ToString(totalCredit) + " Chỉ";
            label2.Text = Convert.ToString(sumPoint / totalCredit);
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            listCourse();
        }
    }
}
