using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThanhThanh.UI;
using System.IO;
using ThanhThanh.DAL;


namespace ThanhThanh
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            formKhachhang form = new formKhachhang();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            formHoadon form = new formHoadon();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            formCuocDT form = new formCuocDT();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            formKhachhang form = new formKhachhang();
            form.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(form);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Bắt đầu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int month, day, hour, minutes, seconds;
            int year = 2018;
            Random rnd = new Random();
            //Open the File
                StreamWriter sw = new StreamWriter(@"C:\Users\Hong\Desktop\Phan lop\ThanhThanh\Test1.txt");
            THONGTINSIM tHONGTINSIM = new THONGTINSIM();
            var list = tHONGTINSIM.GetAllIDSIM();
            foreach (var item in list)
            {
                
                for (int i = 0; i < 10; i++)
                    {
                    THOIGIANSUDUNG tHOIGIANSUDUNG = new THOIGIANSUDUNG();
                    tHOIGIANSUDUNG.IDSim = item.ToString();
                    // thoi gian bat dau    
                    month = rnd.Next(1, 12);
                     day = rnd.Next(1, 29);
                     hour = rnd.Next(0, 23);
                     minutes = rnd.Next(1, 60);
                     seconds = rnd.Next(1, 60);
                     DateTime timex = new DateTime(year, month, day, hour, minutes, seconds);
                    tHOIGIANSUDUNG.TGBD = timex;
                     //tạo tời gian kết thúc
                            int sogiay = rnd.Next(0, 7200);
                            //tinh thoi gian cuoc goi
                            hour = hour + sogiay / 3600;
                            sogiay = sogiay - (sogiay / 3600) * 3600;
                            minutes = minutes + (sogiay / 60);
                            sogiay = sogiay - (sogiay / 60) * 60;
                            seconds = seconds + sogiay;

                            if (seconds >= 60)
                            {
                                minutes++;
                                seconds = seconds - 60;
                            }
                            if (minutes >= 60)
                            {
                                hour++;
                                minutes = minutes - 60;
                            }
                            if (hour >= 23)
                            {
                                day++;
                                hour = hour - 23;
                            }
                    DateTime timey = new DateTime(year, month, day, hour, minutes, seconds);
                    tHOIGIANSUDUNG.TGKT = timey;
                    tHOIGIANSUDUNG.SophutBN = tHOIGIANSUDUNG.tinhsophutbanngay1(timex , timey);
                    tHOIGIANSUDUNG.SophutBD = tHOIGIANSUDUNG.tinhsophutbandem1(timex, timey);
                    tHOIGIANSUDUNG.Gia = (float) tHOIGIANSUDUNG.tinhgia((float)tHOIGIANSUDUNG.SophutBN , (float)tHOIGIANSUDUNG.SophutBD);
                    
                            sw.WriteLine( item.ToString() + "   "+  timex.ToString() + "   " + timey.ToString());
                    tHOIGIANSUDUNG.insert_Thoigiansudung(tHOIGIANSUDUNG);
                    }
                  
                    //close the file

                }
                sw.Close();
                MessageBox.Show("Thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        public DateTime randomtime(int z )
        {
        
            int year = 2018;
            Random rnd = new Random();
                int month = rnd.Next(1,12);
                int day = rnd.Next(1, 30);
                int hour = rnd.Next(0, 25);
                int minutes = rnd.Next(0, 60);
                int seconds = rnd.Next(0, 60);
            DateTime x = new DateTime (year, month, day, hour, minutes, seconds);
            return x; 
        }
    }
}
