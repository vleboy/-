﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统.芳邻路
{
    public partial class ListFllNetForm2 : Form
    {
        public ListFllNetForm2()
        {
            InitializeComponent();
        }

        private void laYardGroundValue1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laYardGroundValue2_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laYardGroundValue3_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laYardGroundValue4_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }
    }
}
