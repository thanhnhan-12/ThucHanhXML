﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
namespace _15_NguyenThanhNhan_04
{
    public partial class Form1 : Form
    {
        String pathMaster = "master.xml";
        String pathDetail = "detail.xml";
        String pathItem = "item.xml";
        String pathCustomer = "customer.xml";

        XDocument xMaster, xDetail, xItem, xCustomer;
        String today = DateTime.Now.ToString("d/M/yyyy");

        public Form1()
        {
            InitializeComponent();
            InitCboOrderNo();
            InitCboCCode();
        }

        void InitCboOrderNo()
        {
            xMaster = XDocument.Load(pathMaster);
            var qr = (from XElement e in xMaster.Descendants("order")
                      orderby e.Attribute("orderno").Value descending
                      select e.Attribute("orderno").Value).Distinct();
            foreach (String str in qr)
            {
                cboOrder.Items.Add(str);
            }
        }

        void InitCboCCode()
        {
            xCustomer = XDocument.Load(pathCustomer);
            var qr = (from XElement e in xCustomer.Descendants("customer")
                      orderby e.Attribute("ccode").Value
                      select e.Attribute("ccode").Value).Distinct();
            foreach (String str in qr)
            {
                cboCCode.Items.Add(str);
            }
        }

        private void listCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listCustomer();
        }

        void InitGrid(String header, String width)
        {
            /*
            Header: các tên cột, Width: các độ rộng cột tương ứng
            */
            String[] hd = header.Split(',');
            String[] wd = width.Split(',');
            for (int i = 0; i < dgvData.ColumnCount; i++)
            {
                dgvData.Columns[i].HeaderText = hd[i];
                dgvData.Columns[i].Width = int.Parse(wd[i]);
            }
        }

        void listCustomer()
        {
            /* -- Hiển thị danh sách khách hàng vào grid --*/
            xCustomer = XDocument.Load(pathCustomer);
            var qr = from XElement e in xCustomer.Descendants("customer")
                     select new
                     {
                         code = e.Attribute("ccode").Value,
                         cname = e.Attribute("cname").Value,
                         add = e.Attribute("address").Value,
                     };
            // Không cần dgvData.Rows.Clear();
            lblTotal.Text = qr.Count().ToString() + " khách hàng";
            dgvData.DataSource = qr.ToList();
            String hd = "Ccode,Cname,Address";
            String wd = "100, 215, 300";
            InitGrid(hd, wd);
        }

        private void listItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listItem();
        }

        void listItem()
        {
            /* -- Hiển thị danh sách hàng hóa lên grid --- */
            xItem = XDocument.Load(pathItem);
            var qr = from XElement e in xItem.Descendants("item")
                     orderby e.Attribute("icode").Value
                     select new
                     {
                         code = e.Attribute("icode").Value,
                         name = e.Attribute("iname").Value,
                         price = e.Attribute("rate").Value
                     };
            dgvData.DataSource = qr.ToList();
            String hd = "Icode, Iname, Price";
            String wd = "100, 305, 210";
            InitGrid(hd, wd);
            lblTotal.Text = qr.Count().ToString() + " mặt hàng";
        }

        private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewOrderDetail(cboOrder.Text);
        }

        void viewCcodeItem(String ccode)
        {
            MessageBox.Show(ccode);
        }

        private void cboCCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            agreItemOrdered(cboCCode.Text);
        }

        String isCustomer(String ccode)
        {
            String cname = "";
            xCustomer = XDocument.Load(pathCustomer);
            var qr = from XElement e in
            xCustomer.Descendants("customer")
                     where e.Attribute("ccode").Value == ccode
                     select new
                     {
                         cname = e.Attribute("cname").Value
                     };
            if (qr.Count() > 0) cname = qr.First().cname;
            return cname;
        }

        void agreItemOrdered(String ccode)
        {
            /* -- Tổng hợp hàng đã đặt mua bởi khách có mã ccode --*/
            xDetail = XDocument.Load(pathDetail);
            xItem = XDocument.Load(pathItem);
            xMaster = XDocument.Load(pathMaster);
            var qr1 = from em in xMaster.Descendants("order")
                      join ed in xDetail.Descendants("item")
                      on em.Attribute("orderno").Value equals
                      ed.Attribute("orderno").Value
                      join ei in xItem.Descendants("item")
                      on ed.Attribute("icode").Value equals
                      ei.Attribute("icode").Value
                      where em.Attribute("ccode").Value == ccode
                      group int.Parse(ed.Attribute("qty").Value) *
                      int.Parse(ed.Attribute("price").Value)
                      by new
                      {
                          icode = ed.Attribute("icode").Value,
                          iname = ei.Attribute("iname").Value
                      }
            into g
                      select new
                      {
                          icode = g.Key.icode,
                          iname = g.Key.iname,
                          amount = g.Sum(),
                          note = ""
                      };
            var qr2 = from XElement ed in xDetail.Descendants("item")
                      group int.Parse(ed.Attribute("qty").Value)
                      by ed.Attribute("icode").Value into g2
                      select new
                      {
                          icode = g2.Key,
                          qty = g2.Sum()
                      };
            var qr = from e1 in qr1
                     join e2 in qr2 on e1.icode equals e2.icode
                     select new
                     {
                         icode = e1.icode,
                         iname = e1.iname,
                         Qty = e2.qty,
                         Amount = e1.amount
                     };
            dgvData.DataSource = qr.ToList();
            InitGrid("Icode,Iname,Qty,Amount", "100,215,100,200");

            int total = 0;
            foreach (var obj in qr1)
            {
                total += obj.amount;
            }
            lblTotal.Text = total.ToString();
            lblCustomer.Text = isCustomer(cboCCode.Text);
        }
        void viewOrderDetail(String orderno)
        {
            /* -- Hiển thị chi tiết đơn hàng có số orderno -- */

            xCustomer = XDocument.Load(pathCustomer);
            xMaster = XDocument.Load(pathMaster);
            xDetail = XDocument.Load(pathDetail);
            xItem = XDocument.Load(pathItem);
            // Xác định họ tên khách hàng
            var qr1 = from XElement ec in
            xCustomer.Descendants("customer")
                      join XElement em in xMaster.Descendants("order")
                      on ec.Attribute("ccode").Value
                      equals em.Attribute("ccode").Value
                      where em.Attribute("orderno").Value == orderno
                      select new
                      {
                          cname = ec.Attribute("cname").Value
                      };
            lblCustomer.Text = qr1.First().cname;
            // Hiển thị chi tiết đơn hàng orderno
            var qr2 = from XElement ed in xDetail.Descendants("item")
                      join XElement ei in xItem.Descendants("item")
                      on ed.Attribute("icode").Value equals
                      ei.Attribute("icode").Value
                      where ed.Attribute("orderno").Value == orderno
                      orderby ed.Attribute("icode").Value
                      select new
                      {
                          icode = ed.Attribute("icode").Value,
                          iname = ei.Attribute("iname").Value,
                          qty = ed.Attribute("qty").Value,
                          price = ed.Attribute("price").Value,
                          amount =
                      (int.Parse(ed.Attribute("qty").Value) *
                      int.Parse(ed.Attribute("price").Value)).ToString()
                      };
            dgvData.DataSource = qr2.ToList();
            String hd = "Icode, Iname, Qty, Price, Amount";
            String wd = "90,240,90,90,105";
            InitGrid(hd, wd);
            // Tính tổng giá trị đơn hàng
            int total = 0;
            foreach (var obj in qr2)
            {
                total += int.Parse(obj.amount);
            }
            lblTotal.Text = total.ToString() + " triệu đồng";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
