using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;

namespace 草堂街道社会智能数据管理系统
{
    partial class MapMainForm
    {
        public Form main = null;
        public string grid = null;
        public string district = null;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// BitmapRegion BitmapRegion = new BitmapRegion();
        /// 
        BitmapRegion BitmapRegion = new BitmapRegion();
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mytm1 = new TM.mytm();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 4;
            this.button1.Tag = "list";
            this.button1.Text = "详细信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::草堂街道社会智能数据管理系统.Properties.Resources.map;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 594);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // mytm1
            // 
            this.mytm1.BackColor = System.Drawing.Color.Transparent;
            this.mytm1.Location = new System.Drawing.Point(123, 266);
            this.mytm1.Name = "mytm1";
            this.mytm1.Size = new System.Drawing.Size(199, 278);
            this.mytm1.TabIndex = 5;
            this.mytm1.Tag = "ct_grid_1";
            this.mytm1.Click += new System.EventHandler(this.mytm1_Click);
            // 
            // MapMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.mytm1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MapMainForm";
            this.Text = "地图模式";
            this.Load += new System.EventHandler(this.MapMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private TM.mytm mytm1;
    }
}