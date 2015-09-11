namespace 草堂街道社会智能数据管理系统
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.显示模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地图模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.laUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示模式ToolStripMenuItem,
            this.人员管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 显示模式ToolStripMenuItem
            // 
            this.显示模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.列表模式ToolStripMenuItem,
            this.地图模式ToolStripMenuItem});
            this.显示模式ToolStripMenuItem.Name = "显示模式ToolStripMenuItem";
            this.显示模式ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.显示模式ToolStripMenuItem.Text = "显示模式";
            // 
            // 列表模式ToolStripMenuItem
            // 
            this.列表模式ToolStripMenuItem.Name = "列表模式ToolStripMenuItem";
            this.列表模式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.列表模式ToolStripMenuItem.Tag = "list";
            this.列表模式ToolStripMenuItem.Text = "列表模式";
            this.列表模式ToolStripMenuItem.Click += new System.EventHandler(this.列表模式ToolStripMenuItem_Click);
            // 
            // 地图模式ToolStripMenuItem
            // 
            this.地图模式ToolStripMenuItem.Name = "地图模式ToolStripMenuItem";
            this.地图模式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.地图模式ToolStripMenuItem.Tag = "map";
            this.地图模式ToolStripMenuItem.Text = "地图模式";
            // 
            // 人员管理ToolStripMenuItem
            // 
            this.人员管理ToolStripMenuItem.Name = "人员管理ToolStripMenuItem";
            this.人员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人员管理ToolStripMenuItem.Tag = "manager";
            this.人员管理ToolStripMenuItem.Text = "人员管理";
            this.人员管理ToolStripMenuItem.Click += new System.EventHandler(this.人员管理ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(835, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎您：";
            // 
            // laUser
            // 
            this.laUser.AutoSize = true;
            this.laUser.BackColor = System.Drawing.Color.White;
            this.laUser.Location = new System.Drawing.Point(882, 7);
            this.laUser.Name = "laUser";
            this.laUser.Size = new System.Drawing.Size(0, 12);
            this.laUser.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.laUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "草堂街道社会智能数据管理系统";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 显示模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地图模式ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laUser;
        private System.Windows.Forms.ToolStripMenuItem 人员管理ToolStripMenuItem;
    }
}

