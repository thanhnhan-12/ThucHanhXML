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


namespace _15_NguyenThanhNhan_04
{
    public partial class Form1 : Form
    {
        public String path = "student.xml";
        // Tạo folder data ngang cấp với Debug, chứa students.xml
        // Khai báo các biến chung
        public static XmlDocument xmlDoc = new XmlDocument();
        //Library lb = new Library();
        public XmlNodeList list;
        int current = 0; // index của list hiện thời
        int total = 0; // tổng số node của list
        public static String scode; // dùng trao đổi giữa các form
        public static String sname; //-nt-
        public static XmlElement student;
        public static XmlNodeList cur_stu_course; // Điểm của s.viên
        string current_class = "ALL"; // Xem tất cả các lớp
        public string cgroup = "ALL";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initForm(current);
            initGrid("ALL");
            initCombo();
            grid2textbox(0);
        }

        void load(string path)
        {
            // load tệp xml và làm thay đổi biến chung xmlDoc
            if (File.Exists(path))
            {
                try
                {
                    xmlDoc.Load(path);
                    list = xmlDoc.GetElementsByTagName("student");
                    total = list.Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void grid2textbox(int cur)
        {
            // đưa dữ liệu dòng thứ cur lên textbox
            this.txtCode.Text =
            this.dgvStudent.Rows[cur].Cells[0].Value.ToString();
            this.txtFullName.Text =
            this.dgvStudent.Rows[cur].Cells[1].Value.ToString();
            this.txtClass.Text =
            this.dgvStudent.Rows[cur].Cells[2].Value.ToString();
            this.txtAddress.Text =
            this.dgvStudent.Rows[cur].Cells[3].Value.ToString();
        }


        private void initForm(int cur)
        {
            // Khởi tạo Form
            load(path);
            XmlElement x = (XmlElement)list[cur];
            student = x;
            txtCode.Text = x.GetAttribute("code");
            txtFullName.Text = x.GetAttribute("name");
            txtClass.Text = x.GetAttribute("class");
            txtAddress.Text = x.GetAttribute("address");
            scode = x.GetAttribute("code");
            sname = x.GetAttribute("name");
            cur_stu_course = x.ChildNodes;
        }
        private void initCombo()
        {
            // Khởi tạo ComboBox là các lớp trong dữ liệu
            load(path);
            string tmp = "";
            string group = "";
            list = xmlDoc.GetElementsByTagName("student");
            cboClass.Items.Add("ALL");
            foreach (XmlElement x in list)
            {
                group = x.GetAttribute("class");
                if (!(tmp.IndexOf(group) >= 0))
                {
                    tmp += group;
                    cboClass.Items.Add(group);
                }
            } // end for
        }
        private void initGrid(string cgroup)
        {
            // Khởi tại grid, nạp danh sách sinh viên
            dgvStudent.Rows.Clear();
            dgvStudent.ColumnCount = 4;
            dgvStudent.Columns[0].Name = "Code";
            dgvStudent.Columns[0].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[0].HeaderCell
            .Style.Alignment =
           DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[0].Width = 85;
            dgvStudent.Columns[1].Name = "Name";
            dgvStudent.Columns[1].Width = 180;
            dgvStudent.Columns[2].Name = "Class";
            dgvStudent.Columns[2].DefaultCellStyle
            .Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[2].HeaderCell
            .Style.Alignment =
           DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[2].Width = 85;
            dgvStudent.Columns[3].Name = "Address";
            dgvStudent.Columns[3].Width = 180;
            string code, fullname, group, address;
            load(path);
            foreach (XmlElement x in list)
            {
                group = x.GetAttribute("class");
                if (cgroup == "ALL" || cgroup == group)
                {
                    code = x.GetAttribute("code");
                    fullname = x.GetAttribute("name");
                    address = x.GetAttribute("address");
                    dgvStudent.Rows.Add(code, fullname,
                     group, address);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (current == 0) current = total - 1;
            else current--;
            initForm(current);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (current < total - 1) current++;
            else current = 0;
            initForm(current);
        }


        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = dgvStudent.CurrentRow.Index;
            //txtCode.Text = (string)dgvStudent.CurrentRow.Cells[0].Value;
            //scode = (string)dgvStudent.CurrentRow.Cells[0].Value;
            //txtFullName.Text = (string)dgvStudent.CurrentRow.Cells[1].Value;
            //sname = (string)dgvStudent.CurrentRow.Cells[1].Value;
            //txtClass.Text = (string)dgvStudent.CurrentRow.Cells[2].Value;
            //txtAddress.Text = (string)dgvStudent.CurrentRow.Cells[3].Value;
            current = dgvStudent.CurrentRow.Index;
            initForm(current);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (current < total - 1) current++;
            else current = 0;
            initForm(current);
        }

        private void btnCourseOfStudent_Click(object sender, EventArgs e)
        {
            CourseOfStudent cs = new CourseOfStudent();
            cs.Show(); // Mở form CourseOfStudent

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddPoint cs = new AddPoint();
            cs.Show(); // Mở form CourseOfStudent
        }

        public void emptyTextBox(bool ok) {
            if (ok) {
                this.txtCode.Text = "";
            }
            this.txtFullName.Text = "";
            this.txtClass.Text = "";
            this.txtAddress.Text = "";
        }

        private void Delete(string code)
        {
            Library lb = new Library();
            xmlDoc = lb.OpenXml(path);
            if(code.Trim() == "")
            {
                MessageBox.Show("Let select student in DataGridView");
            }
            else
            {
                XmlElement node = lb.Search(path, ref xmlDoc, "student", "code", code);
                DialogResult res = MessageBox.Show("Are you sure you want to Delete",
                "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if(res == DialogResult.Yes)
                {
                    node.ParentNode.RemoveChild(node);
                    xmlDoc.Save(path);
                    initGrid("ALL");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete(txtCode.Text);
        }

        private void Update(string code)
        {
            Library lb = new Library();
            if (btnUpdate.Text == "Update")
            {
                btnUpdate.Text = "Save";
                txtCode.Enabled = false;
                txtFullName.ForeColor = Color.Red;
            }
            else
            {
                if(code != "")
                {
                    XmlElement node = (XmlElement)lb.Search(path,
                               ref xmlDoc, "student", "code", code);
                    node.SetAttribute("name", txtFullName.Text);
                    node.SetAttribute("class", txtClass.Text);
                    node.SetAttribute("address", txtAddress.Text);
                    xmlDoc.Save(path);
                    initGrid("ALL");
                }
                btnUpdate.Text = "Update";
                btnUpdate.ForeColor = Color.Navy;
                txtCode.Enabled = true; 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update(txtCode.Text);
        }

        private void Insert(string code)
        {
            Library lb = new Library();
            if(btnInsert.Text == "Insert")
            {
                btnInsert.Text = "Save";
                txtCode.Enabled = false;
                txtFullName.ForeColor = Color.Red;
                btnInsert.ForeColor = Color.Red;
                txtFullName.Text = "";
                //txtCode.Text = "";
                txtClass.Text = "";
                txtAddress.Text = "";
            }
            else
            {
                if(code != "")
                {
                    XmlElement node = xmlDoc.CreateElement("student");
                    node.SetAttribute("code", txtCode.Text);
                    node.SetAttribute("name", txtFullName.Text);
                    node.SetAttribute("class", txtClass.Text);
                    node.SetAttribute("address", txtAddress.Text);
                    xmlDoc.DocumentElement.AppendChild(node);
                    xmlDoc.Save(path);
                    initGrid("ALL");
                }
                btnInsert.Text = "Insert";
                btnInsert.ForeColor = Color.Navy;
                txtCode.Enabled = true;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert(txtCode.Text);
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string group = cboClass.Text;
            initGrid(group);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
