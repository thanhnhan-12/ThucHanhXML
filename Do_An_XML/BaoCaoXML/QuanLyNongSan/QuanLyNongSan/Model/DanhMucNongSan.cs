using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QuanLyNongSan.Model
{
    class DanhMucNongSan
    {

        XMLFile XmlFile = new XMLFile();
        public XmlNodeList getListMD()
        {
            XmlDocument XDoc = XmlFile.getXmlDocument("DanhMucNongSans.xml");
            XmlNodeList nodeList = XDoc.SelectNodes("/DanhMucNongSans/DanhMucNongSan");
            for (int i = 0; i < nodeList.Count; i++) {
                XmlNode a = nodeList[i];
  

            }
                return nodeList;

        }
    }
}
