using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace _15_NguyenThanhNhan_04
{
    public partial class Login : Form
    {
        public static Form lg;
        Library lb = new Library();
        XmlDocument xmlUser = null;
        //string pathUser = "../data/user.xml";
        string pathUser = Application.StartupPath + "\\data\\user.xml";
        bool ok = false;

        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user, pass;
            XmlNodeList list = lb.GetList(pathUser, ref xmlUser, "user");
            foreach (XmlElement ele in list)
            {
                user = ele.GetAttribute("code");
                pass = ele.GetAttribute("pass");
                if (user == txtUser.Text.ToUpper().Trim() &&
                    pass == txtPass.Text.Trim())
                {
                    ok = true;
                    break;
                }
            }   //end for

            if (ok)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                // Ngăn không cho DashBoard đóng lại” db.Closed +
                // Biểu thức Lambda: (s,args) => this.Close();//đóng form Login          
                db.Closed += (s, args) => this.Close();
                db.Show();
            }

            else MessageBox.Show("Data Is'nt Valid", "Information",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

