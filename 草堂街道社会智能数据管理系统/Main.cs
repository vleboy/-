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
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            laUser.Text = PropetyClass.User;
            CommonUse commUse = new CommonUse();
            var x = (Form)sender;

            commUse.ShowForm(x.Tag.ToString(), this);
        }

        private void 列表模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;
            
            commUse.ShowForm(x.Tag.ToString(), this);
        }

        private void 人员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this);
        }
    }
}
