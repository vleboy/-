using System.Windows.Forms;

namespace 草堂街道社会智能数据管理系统.草堂路
{
    partial class ListCtlNetBlockPersonForm
    {
        public Form main = null;
        public int block = 0;
        public int grid = 0;
        public int resident = 0;
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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ladope = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.laforeigner = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lareleased = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lacorrection = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lapoor = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.laalone = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lamental = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lahandicapped = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.laresident = new System.Windows.Forms.Label();
            this.lapreson = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.laold = new System.Windows.Forms.Label();
            this.lasum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lablock = new System.Windows.Forms.Label();
            this.lagrid = new System.Windows.Forms.Label();
            this.ladistrict = new System.Windows.Forms.Label();
            this.tp9 = new System.Windows.Forms.TabPage();
            this.tp8 = new System.Windows.Forms.TabPage();
            this.tp7 = new System.Windows.Forms.TabPage();
            this.tp6 = new System.Windows.Forms.TabPage();
            this.tp5 = new System.Windows.Forms.TabPage();
            this.tp4 = new System.Windows.Forms.TabPage();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.census_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educational = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.features = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMain = new System.Windows.Forms.TabControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn96 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resident_addresss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.now_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.tp9.SuspendLayout();
            this.tp8.SuspendLayout();
            this.tp7.SuspendLayout();
            this.tp6.SuspendLayout();
            this.tp5.SuspendLayout();
            this.tp4.SuspendLayout();
            this.tp3.SuspendLayout();
            this.tp2.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ladope);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.laforeigner);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lareleased);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lacorrection);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lapoor);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.laalone);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lamental);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lahandicapped);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.laresident);
            this.groupBox1.Controls.Add(this.lapreson);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.laold);
            this.groupBox1.Controls.Add(this.lasum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lablock);
            this.groupBox1.Controls.Add(this.lagrid);
            this.groupBox1.Controls.Add(this.ladistrict);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 141);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "院落信息";
            // 
            // ladope
            // 
            this.ladope.AutoSize = true;
            this.ladope.Location = new System.Drawing.Point(661, 97);
            this.ladope.Name = "ladope";
            this.ladope.Size = new System.Drawing.Size(29, 12);
            this.ladope.TabIndex = 26;
            this.ladope.Text = "0000";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(578, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 25;
            this.label26.Text = "吸毒人员数：";
            // 
            // laforeigner
            // 
            this.laforeigner.AutoSize = true;
            this.laforeigner.Location = new System.Drawing.Point(661, 62);
            this.laforeigner.Name = "laforeigner";
            this.laforeigner.Size = new System.Drawing.Size(29, 12);
            this.laforeigner.TabIndex = 24;
            this.laforeigner.Text = "0000";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(578, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 12);
            this.label24.TabIndex = 23;
            this.label24.Text = "境外人员数：";
            // 
            // lareleased
            // 
            this.lareleased.AutoSize = true;
            this.lareleased.Location = new System.Drawing.Point(543, 97);
            this.lareleased.Name = "lareleased";
            this.lareleased.Size = new System.Drawing.Size(29, 12);
            this.lareleased.TabIndex = 22;
            this.lareleased.Text = "0000";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(448, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 12);
            this.label22.TabIndex = 21;
            this.label22.Text = "刑满释放人数：";
            // 
            // lacorrection
            // 
            this.lacorrection.AutoSize = true;
            this.lacorrection.Location = new System.Drawing.Point(413, 97);
            this.lacorrection.Name = "lacorrection";
            this.lacorrection.Size = new System.Drawing.Size(29, 12);
            this.lacorrection.TabIndex = 20;
            this.lacorrection.Text = "0000";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(342, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 19;
            this.label20.Text = "矫正人员数：";
            // 
            // lapoor
            // 
            this.lapoor.AutoSize = true;
            this.lapoor.Location = new System.Drawing.Point(307, 97);
            this.lapoor.Name = "lapoor";
            this.lapoor.Size = new System.Drawing.Size(29, 12);
            this.lapoor.TabIndex = 18;
            this.lapoor.Text = "0000";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "低保人员数：";
            // 
            // laalone
            // 
            this.laalone.AutoSize = true;
            this.laalone.Location = new System.Drawing.Point(189, 97);
            this.laalone.Name = "laalone";
            this.laalone.Size = new System.Drawing.Size(29, 12);
            this.laalone.TabIndex = 16;
            this.laalone.Text = "0000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(106, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "空巢老人数：";
            // 
            // lamental
            // 
            this.lamental.AutoSize = true;
            this.lamental.Location = new System.Drawing.Point(543, 62);
            this.lamental.Name = "lamental";
            this.lamental.Size = new System.Drawing.Size(29, 12);
            this.lamental.TabIndex = 14;
            this.lamental.Text = "0000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 13;
            this.label14.Text = "精神疾病人数：";
            // 
            // lahandicapped
            // 
            this.lahandicapped.AutoSize = true;
            this.lahandicapped.Location = new System.Drawing.Point(413, 62);
            this.lahandicapped.Name = "lahandicapped";
            this.lahandicapped.Size = new System.Drawing.Size(29, 12);
            this.lahandicapped.TabIndex = 12;
            this.lahandicapped.Text = "0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "残疾人数：";
            // 
            // laresident
            // 
            this.laresident.AutoSize = true;
            this.laresident.Location = new System.Drawing.Point(307, 62);
            this.laresident.Name = "laresident";
            this.laresident.Size = new System.Drawing.Size(29, 12);
            this.laresident.TabIndex = 10;
            this.laresident.Text = "0000";
            // 
            // lapreson
            // 
            this.lapreson.AutoSize = true;
            this.lapreson.Location = new System.Drawing.Point(189, 62);
            this.lapreson.Name = "lapreson";
            this.lapreson.Size = new System.Drawing.Size(29, 12);
            this.lapreson.TabIndex = 9;
            this.lapreson.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "常住人口数：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "流动人口数：";
            // 
            // laold
            // 
            this.laold.AutoSize = true;
            this.laold.Location = new System.Drawing.Point(71, 97);
            this.laold.Name = "laold";
            this.laold.Size = new System.Drawing.Size(29, 12);
            this.laold.TabIndex = 6;
            this.laold.Text = "0000";
            // 
            // lasum
            // 
            this.lasum.AutoSize = true;
            this.lasum.Location = new System.Drawing.Point(71, 62);
            this.lasum.Name = "lasum";
            this.lasum.Size = new System.Drawing.Size(29, 12);
            this.lasum.TabIndex = 5;
            this.lasum.Text = "0000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "老年人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "总人数：";
            // 
            // lablock
            // 
            this.lablock.AutoSize = true;
            this.lablock.Location = new System.Drawing.Point(140, 31);
            this.lablock.Name = "lablock";
            this.lablock.Size = new System.Drawing.Size(89, 12);
            this.lablock.TabIndex = 2;
            this.lablock.Text = "青华路25号院落";
            // 
            // lagrid
            // 
            this.lagrid.AutoSize = true;
            this.lagrid.Location = new System.Drawing.Point(81, 31);
            this.lagrid.Name = "lagrid";
            this.lagrid.Size = new System.Drawing.Size(53, 12);
            this.lagrid.TabIndex = 1;
            this.lagrid.Text = "第一网格";
            // 
            // ladistrict
            // 
            this.ladistrict.AutoSize = true;
            this.ladistrict.Location = new System.Drawing.Point(10, 31);
            this.ladistrict.Name = "ladistrict";
            this.ladistrict.Size = new System.Drawing.Size(65, 12);
            this.ladistrict.TabIndex = 0;
            this.ladistrict.Text = "草堂路社区";
            // 
            // tp9
            // 
            this.tp9.Controls.Add(this.dataGridView9);
            this.tp9.Location = new System.Drawing.Point(4, 22);
            this.tp9.Name = "tp9";
            this.tp9.Padding = new System.Windows.Forms.Padding(3);
            this.tp9.Size = new System.Drawing.Size(976, 510);
            this.tp9.TabIndex = 8;
            this.tp9.Text = "吸毒人员";
            this.tp9.UseVisualStyleBackColor = true;
            // 
            // tp8
            // 
            this.tp8.Controls.Add(this.dataGridView8);
            this.tp8.Location = new System.Drawing.Point(4, 22);
            this.tp8.Name = "tp8";
            this.tp8.Padding = new System.Windows.Forms.Padding(3);
            this.tp8.Size = new System.Drawing.Size(976, 510);
            this.tp8.TabIndex = 7;
            this.tp8.Text = "刑满人员";
            this.tp8.UseVisualStyleBackColor = true;
            // 
            // tp7
            // 
            this.tp7.Controls.Add(this.dataGridView7);
            this.tp7.Location = new System.Drawing.Point(4, 22);
            this.tp7.Name = "tp7";
            this.tp7.Padding = new System.Windows.Forms.Padding(3);
            this.tp7.Size = new System.Drawing.Size(976, 510);
            this.tp7.TabIndex = 6;
            this.tp7.Text = "矫正人员";
            this.tp7.UseVisualStyleBackColor = true;
            // 
            // tp6
            // 
            this.tp6.Controls.Add(this.dataGridView6);
            this.tp6.Location = new System.Drawing.Point(4, 22);
            this.tp6.Name = "tp6";
            this.tp6.Padding = new System.Windows.Forms.Padding(3);
            this.tp6.Size = new System.Drawing.Size(976, 510);
            this.tp6.TabIndex = 5;
            this.tp6.Text = "低保人员";
            this.tp6.UseVisualStyleBackColor = true;
            // 
            // tp5
            // 
            this.tp5.Controls.Add(this.dataGridView5);
            this.tp5.Location = new System.Drawing.Point(4, 22);
            this.tp5.Name = "tp5";
            this.tp5.Padding = new System.Windows.Forms.Padding(3);
            this.tp5.Size = new System.Drawing.Size(976, 510);
            this.tp5.TabIndex = 4;
            this.tp5.Text = "境外人员";
            this.tp5.UseVisualStyleBackColor = true;
            // 
            // tp4
            // 
            this.tp4.Controls.Add(this.dataGridView4);
            this.tp4.Location = new System.Drawing.Point(4, 22);
            this.tp4.Name = "tp4";
            this.tp4.Padding = new System.Windows.Forms.Padding(3);
            this.tp4.Size = new System.Drawing.Size(976, 510);
            this.tp4.TabIndex = 3;
            this.tp4.Text = "老年人";
            this.tp4.UseVisualStyleBackColor = true;
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.dataGridView3);
            this.tp3.Location = new System.Drawing.Point(4, 22);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(976, 510);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "残疾人";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.dataGridView2);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(976, 510);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "常住人口";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.dataGridView1);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(976, 510);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "流动人口";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.gender,
            this.age,
            this.card_id,
            this.address,
            this.census_address,
            this.educational,
            this.note,
            this.id,
            this.Column1,
            this.blocks,
            this.features});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(970, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 54;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "sex";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 54;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 54;
            // 
            // card_id
            // 
            this.card_id.DataPropertyName = "card_id";
            this.card_id.HeaderText = "身份证号码";
            this.card_id.Name = "card_id";
            this.card_id.ReadOnly = true;
            this.card_id.Width = 90;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "居住地址";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 78;
            // 
            // census_address
            // 
            this.census_address.DataPropertyName = "census_address";
            this.census_address.HeaderText = "户籍地址";
            this.census_address.Name = "census_address";
            this.census_address.ReadOnly = true;
            this.census_address.Width = 78;
            // 
            // educational
            // 
            this.educational.DataPropertyName = "educational";
            this.educational.HeaderText = "教育程度";
            this.educational.Name = "educational";
            this.educational.ReadOnly = true;
            this.educational.Width = 78;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "备注";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            this.note.Width = 54;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "gender";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // blocks
            // 
            this.blocks.DataPropertyName = "block";
            this.blocks.HeaderText = "所属院落";
            this.blocks.Name = "blocks";
            this.blocks.ReadOnly = true;
            this.blocks.Visible = false;
            // 
            // features
            // 
            this.features.DataPropertyName = "features";
            this.features.HeaderText = "特性ID";
            this.features.Name = "features";
            this.features.ReadOnly = true;
            this.features.Visible = false;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tp1);
            this.tpMain.Controls.Add(this.tp2);
            this.tpMain.Controls.Add(this.tp3);
            this.tpMain.Controls.Add(this.tp4);
            this.tpMain.Controls.Add(this.tp5);
            this.tpMain.Controls.Add(this.tp6);
            this.tpMain.Controls.Add(this.tp7);
            this.tpMain.Controls.Add(this.tp8);
            this.tpMain.Controls.Add(this.tp9);
            this.tpMain.Location = new System.Drawing.Point(12, 159);
            this.tpMain.Name = "tpMain";
            this.tpMain.SelectedIndex = 0;
            this.tpMain.Size = new System.Drawing.Size(984, 536);
            this.tpMain.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ethnic,
            this.photo,
            this.tenants,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.resident_addresss,
            this.dataGridViewTextBoxColumn7,
            this.now_date,
            this.registration_date,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(970, 504);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(970, 504);
            this.dataGridView3.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn13.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 54;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn14.HeaderText = "性别";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 54;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn15.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 54;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn16.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 90;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn17.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 78;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn18.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 78;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn19.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 78;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn20.HeaderText = "备注";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 54;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn21.HeaderText = "id";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn22.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn23.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn24.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(970, 504);
            this.dataGridView4.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn25.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 54;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn26.HeaderText = "性别";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 54;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn27.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 54;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn28.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 90;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn29.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 78;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn30.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 78;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn31.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 78;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn32.HeaderText = "备注";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 54;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn33.HeaderText = "id";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Visible = false;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn34.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Visible = false;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn35.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Visible = false;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn36.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Visible = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView5.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView5.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48});
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(970, 504);
            this.dataGridView5.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn37.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 54;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn38.HeaderText = "性别";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 54;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn39.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 54;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn40.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 90;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn41.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 78;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn42.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 78;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn43.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 78;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn44.HeaderText = "备注";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 54;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn45.HeaderText = "id";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Visible = false;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn46.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Visible = false;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn47.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Visible = false;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn48.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Visible = false;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView6.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView6.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60});
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowHeadersVisible = false;
            this.dataGridView6.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(970, 504);
            this.dataGridView6.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn49.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Width = 54;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn50.HeaderText = "性别";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Width = 54;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn51.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 54;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn52.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Width = 90;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn53.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Width = 78;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn54.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 78;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn55.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 78;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn56.HeaderText = "备注";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Width = 54;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn57.HeaderText = "id";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Visible = false;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn58.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Visible = false;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn59.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Visible = false;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn60.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Visible = false;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView7.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72});
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView7.RowTemplate.Height = 23;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(970, 504);
            this.dataGridView7.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn61.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 54;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn62.HeaderText = "性别";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 54;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn63.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 54;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn64.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Width = 90;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn65.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Width = 78;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn66.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            this.dataGridViewTextBoxColumn66.Width = 78;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn67.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            this.dataGridViewTextBoxColumn67.Width = 78;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn68.HeaderText = "备注";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Width = 54;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn69.HeaderText = "id";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Visible = false;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn70.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            this.dataGridViewTextBoxColumn70.Visible = false;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn71.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.Visible = false;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn72.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.Visible = false;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView8.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75,
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77,
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn82,
            this.dataGridViewTextBoxColumn83,
            this.dataGridViewTextBoxColumn84});
            this.dataGridView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView8.Location = new System.Drawing.Point(3, 3);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowHeadersVisible = false;
            this.dataGridView8.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView8.RowTemplate.Height = 23;
            this.dataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView8.Size = new System.Drawing.Size(970, 504);
            this.dataGridView8.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn73.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            this.dataGridViewTextBoxColumn73.Width = 54;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn74.HeaderText = "性别";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Width = 54;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn75.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Width = 54;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn76.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Width = 90;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn77.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            this.dataGridViewTextBoxColumn77.Width = 78;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn78.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            this.dataGridViewTextBoxColumn78.Width = 78;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn79.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Width = 78;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn80.HeaderText = "备注";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Width = 54;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn81.HeaderText = "id";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            this.dataGridViewTextBoxColumn81.Visible = false;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn82.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            this.dataGridViewTextBoxColumn82.Visible = false;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn83.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            this.dataGridViewTextBoxColumn83.Visible = false;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn84.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            this.dataGridViewTextBoxColumn84.ReadOnly = true;
            this.dataGridViewTextBoxColumn84.Visible = false;
            // 
            // dataGridView9
            // 
            this.dataGridView9.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView9.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView9.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn85,
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn87,
            this.dataGridViewTextBoxColumn88,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90,
            this.dataGridViewTextBoxColumn91,
            this.dataGridViewTextBoxColumn92,
            this.dataGridViewTextBoxColumn93,
            this.dataGridViewTextBoxColumn94,
            this.dataGridViewTextBoxColumn95,
            this.dataGridViewTextBoxColumn96});
            this.dataGridView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView9.Location = new System.Drawing.Point(3, 3);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.ReadOnly = true;
            this.dataGridView9.RowHeadersVisible = false;
            this.dataGridView9.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView9.RowTemplate.Height = 23;
            this.dataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView9.Size = new System.Drawing.Size(970, 504);
            this.dataGridView9.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn85.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            this.dataGridViewTextBoxColumn85.ReadOnly = true;
            this.dataGridViewTextBoxColumn85.Width = 54;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn86.HeaderText = "性别";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            this.dataGridViewTextBoxColumn86.Width = 54;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn87.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.ReadOnly = true;
            this.dataGridViewTextBoxColumn87.Width = 54;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn88.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.ReadOnly = true;
            this.dataGridViewTextBoxColumn88.Width = 90;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn89.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            this.dataGridViewTextBoxColumn89.Width = 78;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn90.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.ReadOnly = true;
            this.dataGridViewTextBoxColumn90.Width = 78;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn91.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.ReadOnly = true;
            this.dataGridViewTextBoxColumn91.Width = 78;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn92.HeaderText = "备注";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            this.dataGridViewTextBoxColumn92.ReadOnly = true;
            this.dataGridViewTextBoxColumn92.Width = 54;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn93.HeaderText = "id";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.ReadOnly = true;
            this.dataGridViewTextBoxColumn93.Visible = false;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn94.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.ReadOnly = true;
            this.dataGridViewTextBoxColumn94.Visible = false;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.DataPropertyName = "block";
            this.dataGridViewTextBoxColumn95.HeaderText = "所属院落";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.ReadOnly = true;
            this.dataGridViewTextBoxColumn95.Visible = false;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.DataPropertyName = "features";
            this.dataGridViewTextBoxColumn96.HeaderText = "特性ID";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.ReadOnly = true;
            this.dataGridViewTextBoxColumn96.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn2.HeaderText = "性别";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "card_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "身份证号码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 90;
            // 
            // ethnic
            // 
            this.ethnic.DataPropertyName = "ethnic";
            this.ethnic.HeaderText = "民族";
            this.ethnic.Name = "ethnic";
            this.ethnic.ReadOnly = true;
            this.ethnic.Width = 54;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "照片";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Width = 54;
            // 
            // tenants
            // 
            this.tenants.DataPropertyName = "tenants";
            this.tenants.HeaderText = "是否租客";
            this.tenants.Name = "tenants";
            this.tenants.ReadOnly = true;
            this.tenants.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "居住地址";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "census_address";
            this.dataGridViewTextBoxColumn6.HeaderText = "户籍地址";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 78;
            // 
            // resident_addresss
            // 
            this.resident_addresss.DataPropertyName = "resident_addresss";
            this.resident_addresss.HeaderText = "现居地址";
            this.resident_addresss.Name = "resident_addresss";
            this.resident_addresss.ReadOnly = true;
            this.resident_addresss.Width = 78;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "educational";
            this.dataGridViewTextBoxColumn7.HeaderText = "教育程度";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 78;
            // 
            // now_date
            // 
            this.now_date.DataPropertyName = "now_date";
            this.now_date.HeaderText = "记录日期";
            this.now_date.Name = "now_date";
            this.now_date.ReadOnly = true;
            this.now_date.Width = 78;
            // 
            // registration_date
            // 
            this.registration_date.DataPropertyName = "registration_date";
            this.registration_date.HeaderText = "签发日期";
            this.registration_date.Name = "registration_date";
            this.registration_date.ReadOnly = true;
            this.registration_date.Width = 78;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn8.HeaderText = "备注";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 54;
            // 
            // ListCtlNetBlockPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tpMain);
            this.Name = "ListCtlNetBlockPersonForm";
            this.Load += new System.EventHandler(this.ListCtlNetBlockPersonForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tp9.ResumeLayout(false);
            this.tp8.ResumeLayout(false);
            this.tp7.ResumeLayout(false);
            this.tp6.ResumeLayout(false);
            this.tp5.ResumeLayout(false);
            this.tp4.ResumeLayout(false);
            this.tp3.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TabPage tp9;
        private TabPage tp8;
        private TabPage tp7;
        private TabPage tp6;
        private TabPage tp5;
        private TabPage tp4;
        private TabPage tp3;
        private TabPage tp2;
        private TabPage tp1;
        private DataGridView dataGridView1;
        private TabControl tpMain;
        private Label ladope;
        private Label label26;
        private Label laforeigner;
        private Label label24;
        private Label lareleased;
        private Label label22;
        private Label lacorrection;
        private Label label20;
        private Label lapoor;
        private Label label18;
        private Label laalone;
        private Label label16;
        private Label lamental;
        private Label label14;
        private Label lahandicapped;
        private Label label12;
        private Label laresident;
        private Label lapreson;
        private Label label9;
        private Label label8;
        private Label laold;
        private Label lasum;
        private Label label5;
        private Label label4;
        private Label lablock;
        private Label lagrid;
        private Label ladistrict;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn card_id;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn census_address;
        private DataGridViewTextBoxColumn educational;
        private DataGridViewTextBoxColumn note;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn blocks;
        private DataGridViewTextBoxColumn features;
        private DataGridView dataGridView9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private DataGridView dataGridView8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private DataGridView dataGridView7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private DataGridView dataGridView6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ethnic;
        private DataGridViewTextBoxColumn photo;
        private DataGridViewTextBoxColumn tenants;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn resident_addresss;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn now_date;
        private DataGridViewTextBoxColumn registration_date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}