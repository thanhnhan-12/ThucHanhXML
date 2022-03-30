using System;
using System.Xml;
using System.IO;
using System.Windows.Forms;


namespace _15_NguyenThanhNhan_04
{
    public class Library
    {
        public XmlDocument OpenXml(string path)
        {
            // Kiểm tra và load tệp được khai báo trong path           	
            if (File.Exists(path))
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    return doc;
                }
                catch (Exception ex)
                {
                    string e = ex.Message.ToString();
                    MessageBox.Show("Data Is'nt Valid",
                         "Information",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Warning);
                }
            }
            MessageBox.Show(path + "not found!", "Information",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return null;
        }   // end function


        public XmlNodeList GetList(string path, ref XmlDocument doc,
              string tag)
        {
            doc = OpenXml(path);
            XmlNodeList list = null;
            if (doc != null)
            {
                list = doc.GetElementsByTagName(tag);
            }
            return list;
        }

        // 
        public XmlElement Search(string path, ref XmlDocument xmlStudent,
               string tag, string att, string value)
        {
            XmlElement node = null;
            XmlNodeList list = GetList(path, ref xmlStudent, tag);
            foreach (XmlElement el in list)
            {
                if (el.GetAttribute(att) == value)
                {
                    node = el;
                    MessageBox.Show("Found");
                    break;
                }
            }
            return node;
        }   // end of method
    }       // end of class
}



