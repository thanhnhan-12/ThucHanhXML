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
using System.IO;
using System.Diagnostics;


namespace _15_NguyenThanhNhan_04
{
    public partial class Student : Form
    {
        // string pathStudent = "../data/student.xml";
        string pathStudent = Application.StartupPath + "\\data\\student.xml";
        XmlDocument xmlStudent = new XmlDocument();
        Library lb = new Library();


        public Student()
        {
            InitializeComponent();
            InitCombo();
            Data2Grid("All");
        }

        void InitCombo()
        {
            // Khởi tạo danh sách các lớp cho combobox
            xmlStudent = lb.OpenXml(pathStudent);
            XmlNodeList list =
                        xmlStudent.GetElementsByTagName("student");
            string tmp = "";
            cboClass.Items.Add("All");
            foreach (XmlElement ele in list)
            {
                string group = ele.GetAttribute("class");
                if (!tmp.Contains(group))
                {
                    tmp = tmp + "," + group;
                    cboClass.Items.Add(group);
                }
            }
        }

        void InitGrid()
        {
            dgvStudent.ColumnCount = 3;
            dgvStudent.Columns[0].Width = 127;
            dgvStudent.Columns[0].Name = "Scode";
            dgvStudent.Columns[1].Width = 260;
            dgvStudent.Columns[1].Name = "SName";
            dgvStudent.Columns[2].Width = 127;
            dgvStudent.Columns[2].Name = "Class";
            dgvStudent.Rows.Clear();
        }

        void Data2Grid(string cgroup)
        {
            // Nạp dữ liệu về sinh viên vào datagridview
            InitGrid();
            xmlStudent = lb.OpenXml(pathStudent);
            XmlNodeList list =
                        xmlStudent.GetElementsByTagName("student");
            foreach (XmlElement ele in list)
            {
                string group = ele.GetAttribute("class");
                if (cgroup == "All" || cgroup == group)
                {
                    string code = ele.GetAttribute("code");
                    string name = ele.GetAttribute("name");
                    dgvStudent.Rows.Add(code, name, group);
                }
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string code = dgvStudent.CurrentRow.Cells[0].Value.ToString();
            string name = dgvStudent.CurrentRow.Cells[1].Value.ToString();
            string group = dgvStudent.CurrentRow.Cells[2].Value.ToString();
            txtCode.Text = code;
            txtName.Text = name;
            txtClass.Text = group;

        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string group = cboClass.Text;
            // Chọn một lớp và hiển thị danh sách lớp lên datagridview
            Data2Grid(group);
        }

        private void Insert()
        {
            if (btnInsert.Text == "Insert")
            {
                btnInsert.Text = "Save";
                btnInsert.ForeColor = Color.Red;
                txtCode.Text = "";
                txtName.Text = "";
                txtClass.Text = "";
                txtCode.Focus();
            }
            else
            {
                XmlElement ele = xmlStudent.CreateElement("student");
                ele.SetAttribute("code", txtCode.Text);
                ele.SetAttribute("name", txtName.Text);
                ele.SetAttribute("class", txtClass.Text);
                xmlStudent.DocumentElement.AppendChild(ele);
                xmlStudent.Save(pathStudent);
                Data2Grid("All");

                btnInsert.Text = "Insert";
                btnInsert.ForeColor = Color.Navy;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void update(string code)
        {
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
                txtCode.Enabled = false;
                txtName.Focus();
                btnUpdate.ForeColor = Color.Red;
            }
            else
            {
                if (code != "")
                {
                    XmlElement node = (XmlElement)lb.Search(pathStudent,
                               ref xmlStudent, "student", "code", code);
                    node.SetAttribute("name", txtName.Text);
                    xmlStudent.Save(pathStudent);
                    Data2Grid("All");
                }
                btnUpdate.Text = "Update";
                btnUpdate.ForeColor = Color.Navy;
                txtCode.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update(txtCode.Text);
        }

        void delete(string code)
        {
            xmlStudent = lb.OpenXml(pathStudent);
            if (code.Trim() == "")
            {
                MessageBox.Show("Let select student in DataGridView");
            }
            else
            {
                XmlElement node = lb.Search(pathStudent, ref
                           xmlStudent, "student", "code", code);
                DialogResult res =
                MessageBox.Show("Are you sure you want to Delete",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    node.ParentNode.RemoveChild(node);
                    xmlStudent.Save(pathStudent);
                    Data2Grid("All");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete(txtCode.Text);
        }
    }
}
