using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TM;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统
{
    public partial class MapMainForm : Form
    {
       
        public MapMainForm()
        {
            InitializeComponent();
           // this.button1.Parent = this.pictureBox1;
             }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  BitmapRegion.CreateControlRegion(, new Bitmap("C:\\Users\\JamesLi\\Documents\\Visual Studio 2015\\Projects\\草堂街道社会智能数据管理系统\\草堂街道社会智能数据管理系统\\mapico\\map-ct.png"));
           
        }

        private void MapMainForm_Load(object sender, EventArgs e)
        {
            mytm1.Parent = pictureBox1;
           
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //  BitmapRegion.CreateControlRegion(this, new Bitmap("C:\\Users\\JamesLi\\Documents\\Visual Studio 2015\\Projects\\草堂街道社会智能数据管理系统\\草堂街道社会智能数据管理系统\\mapico\\map-ct.png"));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void tm1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void tm_main_ct1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void tm_sxq_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void tm_ct_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("12312313");
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void tm_sxq_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tm_qt_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void tm_fl_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void mytm1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (mytm)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }
    }
}
