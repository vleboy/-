using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统.mapico
{
    public partial class map_ct_grids_9 : Form
    {
        public map_ct_grids_9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (Button)sender;
            commUse.ShowForm(x.Tag.ToString(), this.main);
        }
    }
}
