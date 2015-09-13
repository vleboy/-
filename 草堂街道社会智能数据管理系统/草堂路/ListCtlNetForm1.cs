using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统.草堂路
{
    public partial class ListCtlNetForm1 : Form
    {
        public ListCtlNetForm1()
        {
            InitializeComponent();
        }

        private void laTitle_Click(object sender, EventArgs e)
        {

        }

        private void ListCtlNetForm1_Load(object sender, EventArgs e)
        {

        }

        private void laYardGroundValue4_Click(object sender, EventArgs e)
        {

        }

        private void laYardGroundValue1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCommunistTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
