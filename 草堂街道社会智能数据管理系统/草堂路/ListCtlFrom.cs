using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统
{
    public partial class ListCtlFrom : Form
    {
        public ListCtlFrom()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void laNetRange1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }
    }
}
