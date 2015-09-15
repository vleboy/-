using System.Windows.Forms;

namespace 草堂街道社会智能数据管理系统
{
    partial class ListMainForm
    {
       public Form main = null; 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMainForm));
            this.laTitle1 = new System.Windows.Forms.Label();
            this.laDgwsjTitle = new System.Windows.Forms.Label();
            this.laDgwsjName = new System.Windows.Forms.Label();
            this.laBgszrTitle = new System.Windows.Forms.Label();
            this.laBgszrName = new System.Windows.Forms.Label();
            this.laNetRange = new System.Windows.Forms.Label();
            this.laSXQ = new System.Windows.Forms.Label();
            this.laCTL = new System.Windows.Forms.Label();
            this.laQTL = new System.Windows.Forms.Label();
            this.laFLL = new System.Windows.Forms.Label();
            this.laYardTitle = new System.Windows.Forms.Label();
            this.laYardValue = new System.Windows.Forms.Label();
            this.laFamilyTitle = new System.Windows.Forms.Label();
            this.laFamilyValue = new System.Windows.Forms.Label();
            this.laHouseTitle = new System.Windows.Forms.Label();
            this.laHouseValue = new System.Windows.Forms.Label();
            this.laUnitTitle = new System.Windows.Forms.Label();
            this.laUnitValue = new System.Windows.Forms.Label();
            this.laCommunityPopulationTitle = new System.Windows.Forms.Label();
            this.laFamilyPopulationTtile = new System.Windows.Forms.Label();
            this.laCommunityPopulationValue = new System.Windows.Forms.Label();
            this.laFamilyPopulationValue = new System.Windows.Forms.Label();
            this.laMobilePopulationTtile = new System.Windows.Forms.Label();
            this.laMobilePopulationValue = new System.Windows.Forms.Label();
            this.laCommunistTitle = new System.Windows.Forms.Label();
            this.laCommunistValue = new System.Windows.Forms.Label();
            this.laOlderTitle = new System.Windows.Forms.Label();
            this.laOlderValue = new System.Windows.Forms.Label();
            this.laAloneOlderTitle = new System.Windows.Forms.Label();
            this.laAloneOlderValue = new System.Windows.Forms.Label();
            this.laHandicappedTitle = new System.Windows.Forms.Label();
            this.laMentalTitle = new System.Windows.Forms.Label();
            this.laHandicappedValue = new System.Windows.Forms.Label();
            this.laMentalValue = new System.Windows.Forms.Label();
            this.laPriorityTitle = new System.Windows.Forms.Label();
            this.laPriorityValue = new System.Windows.Forms.Label();
            this.laForeignerTitle = new System.Windows.Forms.Label();
            this.laForeignerValue = new System.Windows.Forms.Label();
            this.laLowestFmailyTitle = new System.Windows.Forms.Label();
            this.laLowestFmailyValue = new System.Windows.Forms.Label();
            this.laLowestPeopleTitle = new System.Windows.Forms.Label();
            this.laLowestPeopleValue = new System.Windows.Forms.Label();
            this.laCleanerTitle = new System.Windows.Forms.Label();
            this.laCleanerValue = new System.Windows.Forms.Label();
            this.laEmphasisTitle = new System.Windows.Forms.Label();
            this.laEmphasisValue = new System.Windows.Forms.Label();
            this.laUnemploymentTitle = new System.Windows.Forms.Label();
            this.laUnemploymentValue = new System.Windows.Forms.Label();
            this.laDopeTitle = new System.Windows.Forms.Label();
            this.laDopeValue = new System.Windows.Forms.Label();
            this.laCorrectTitle = new System.Windows.Forms.Label();
            this.laCorrectValue = new System.Windows.Forms.Label();
            this.laReleaseTitle = new System.Windows.Forms.Label();
            this.laReleaseValue = new System.Windows.Forms.Label();
            this.gbListMain = new System.Windows.Forms.GroupBox();
            this.gbListMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitle1
            // 
            this.laTitle1.AutoSize = true;
            this.laTitle1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laTitle1.Location = new System.Drawing.Point(300, 130);
            this.laTitle1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laTitle1.Name = "laTitle1";
            this.laTitle1.Size = new System.Drawing.Size(365, 38);
            this.laTitle1.TabIndex = 0;
            this.laTitle1.Text = "草堂办事处基础网格汇总表";
            // 
            // laDgwsjTitle
            // 
            this.laDgwsjTitle.AutoSize = true;
            this.laDgwsjTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDgwsjTitle.Location = new System.Drawing.Point(64, 201);
            this.laDgwsjTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDgwsjTitle.Name = "laDgwsjTitle";
            this.laDgwsjTitle.Size = new System.Drawing.Size(126, 25);
            this.laDgwsjTitle.TabIndex = 1;
            this.laDgwsjTitle.Text = "党工委书记：";
            // 
            // laDgwsjName
            // 
            this.laDgwsjName.AutoSize = true;
            this.laDgwsjName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDgwsjName.Location = new System.Drawing.Point(217, 201);
            this.laDgwsjName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDgwsjName.Name = "laDgwsjName";
            this.laDgwsjName.Size = new System.Drawing.Size(69, 25);
            this.laDgwsjName.TabIndex = 2;
            this.laDgwsjName.Text = "贾定邦";
            // 
            // laBgszrTitle
            // 
            this.laBgszrTitle.AutoSize = true;
            this.laBgszrTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laBgszrTitle.Location = new System.Drawing.Point(506, 201);
            this.laBgszrTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laBgszrTitle.Name = "laBgszrTitle";
            this.laBgszrTitle.Size = new System.Drawing.Size(126, 25);
            this.laBgszrTitle.TabIndex = 3;
            this.laBgszrTitle.Text = "办事处主任：";
            this.laBgszrTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // laBgszrName
            // 
            this.laBgszrName.AutoSize = true;
            this.laBgszrName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laBgszrName.Location = new System.Drawing.Point(656, 201);
            this.laBgszrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laBgszrName.Name = "laBgszrName";
            this.laBgszrName.Size = new System.Drawing.Size(50, 25);
            this.laBgszrName.TabIndex = 4;
            this.laBgszrName.Text = "彭伟";
            // 
            // laNetRange
            // 
            this.laNetRange.AutoSize = true;
            this.laNetRange.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laNetRange.Location = new System.Drawing.Point(64, 251);
            this.laNetRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laNetRange.Name = "laNetRange";
            this.laNetRange.Size = new System.Drawing.Size(107, 25);
            this.laNetRange.TabIndex = 5;
            this.laNetRange.Text = "网络范围：";
            // 
            // laSXQ
            // 
            this.laSXQ.AutoSize = true;
            this.laSXQ.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laSXQ.Location = new System.Drawing.Point(637, 251);
            this.laSXQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laSXQ.Name = "laSXQ";
            this.laSXQ.Size = new System.Drawing.Size(107, 25);
            this.laSXQ.TabIndex = 6;
            this.laSXQ.Tag = "4";
            this.laSXQ.Text = "送仙桥社区";
            this.laSXQ.Click += new System.EventHandler(this.laSXQ_Click);
            // 
            // laCTL
            // 
            this.laCTL.AutoSize = true;
            this.laCTL.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCTL.Location = new System.Drawing.Point(258, 251);
            this.laCTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCTL.Name = "laCTL";
            this.laCTL.Size = new System.Drawing.Size(107, 25);
            this.laCTL.TabIndex = 7;
            this.laCTL.Tag = "1";
            this.laCTL.Text = "草堂路社区";
            this.laCTL.Click += new System.EventHandler(this.laCTL_Click);
            // 
            // laQTL
            // 
            this.laQTL.AutoSize = true;
            this.laQTL.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laQTL.Location = new System.Drawing.Point(382, 251);
            this.laQTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laQTL.Name = "laQTL";
            this.laQTL.Size = new System.Drawing.Size(107, 25);
            this.laQTL.TabIndex = 8;
            this.laQTL.Tag = "2";
            this.laQTL.Text = "琴台路社区";
            this.laQTL.Click += new System.EventHandler(this.laQTL_Click);
            // 
            // laFLL
            // 
            this.laFLL.AutoSize = true;
            this.laFLL.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFLL.Location = new System.Drawing.Point(506, 251);
            this.laFLL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFLL.Name = "laFLL";
            this.laFLL.Size = new System.Drawing.Size(107, 25);
            this.laFLL.TabIndex = 9;
            this.laFLL.Tag = "3";
            this.laFLL.Text = "芳邻路社区";
            this.laFLL.Click += new System.EventHandler(this.laFLL_Click);
            // 
            // laYardTitle
            // 
            this.laYardTitle.AutoSize = true;
            this.laYardTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardTitle.Location = new System.Drawing.Point(50, 306);
            this.laYardTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardTitle.Name = "laYardTitle";
            this.laYardTitle.Size = new System.Drawing.Size(88, 25);
            this.laYardTitle.TabIndex = 10;
            this.laYardTitle.Text = "院落数：";
            // 
            // laYardValue
            // 
            this.laYardValue.AutoSize = true;
            this.laYardValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laYardValue.Location = new System.Drawing.Point(184, 306);
            this.laYardValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laYardValue.Name = "laYardValue";
            this.laYardValue.Size = new System.Drawing.Size(56, 25);
            this.laYardValue.TabIndex = 11;
            this.laYardValue.Text = "0000";
            // 
            // laFamilyTitle
            // 
            this.laFamilyTitle.AutoSize = true;
            this.laFamilyTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyTitle.Location = new System.Drawing.Point(277, 306);
            this.laFamilyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyTitle.Name = "laFamilyTitle";
            this.laFamilyTitle.Size = new System.Drawing.Size(69, 25);
            this.laFamilyTitle.TabIndex = 12;
            this.laFamilyTitle.Text = "户数：";
            // 
            // laFamilyValue
            // 
            this.laFamilyValue.AutoSize = true;
            this.laFamilyValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyValue.Location = new System.Drawing.Point(422, 306);
            this.laFamilyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyValue.Name = "laFamilyValue";
            this.laFamilyValue.Size = new System.Drawing.Size(67, 25);
            this.laFamilyValue.TabIndex = 13;
            this.laFamilyValue.Text = "00000";
            // 
            // laHouseTitle
            // 
            this.laHouseTitle.AutoSize = true;
            this.laHouseTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseTitle.Location = new System.Drawing.Point(514, 306);
            this.laHouseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseTitle.Name = "laHouseTitle";
            this.laHouseTitle.Size = new System.Drawing.Size(69, 25);
            this.laHouseTitle.TabIndex = 14;
            this.laHouseTitle.Text = "栋数：";
            // 
            // laHouseValue
            // 
            this.laHouseValue.AutoSize = true;
            this.laHouseValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHouseValue.Location = new System.Drawing.Point(656, 306);
            this.laHouseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHouseValue.Name = "laHouseValue";
            this.laHouseValue.Size = new System.Drawing.Size(45, 25);
            this.laHouseValue.TabIndex = 15;
            this.laHouseValue.Text = "620";
            // 
            // laUnitTitle
            // 
            this.laUnitTitle.AutoSize = true;
            this.laUnitTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitTitle.Location = new System.Drawing.Point(744, 306);
            this.laUnitTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitTitle.Name = "laUnitTitle";
            this.laUnitTitle.Size = new System.Drawing.Size(88, 25);
            this.laUnitTitle.TabIndex = 16;
            this.laUnitTitle.Text = "单元数：";
            // 
            // laUnitValue
            // 
            this.laUnitValue.AutoSize = true;
            this.laUnitValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnitValue.Location = new System.Drawing.Point(898, 306);
            this.laUnitValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnitValue.Name = "laUnitValue";
            this.laUnitValue.Size = new System.Drawing.Size(56, 25);
            this.laUnitValue.TabIndex = 17;
            this.laUnitValue.Text = "1554";
            // 
            // laCommunityPopulationTitle
            // 
            this.laCommunityPopulationTitle.AutoSize = true;
            this.laCommunityPopulationTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationTitle.Location = new System.Drawing.Point(50, 355);
            this.laCommunityPopulationTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationTitle.Name = "laCommunityPopulationTitle";
            this.laCommunityPopulationTitle.Size = new System.Drawing.Size(88, 25);
            this.laCommunityPopulationTitle.TabIndex = 18;
            this.laCommunityPopulationTitle.Text = "总人口：";
            // 
            // laFamilyPopulationTtile
            // 
            this.laFamilyPopulationTtile.AutoSize = true;
            this.laFamilyPopulationTtile.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationTtile.Location = new System.Drawing.Point(277, 355);
            this.laFamilyPopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationTtile.Name = "laFamilyPopulationTtile";
            this.laFamilyPopulationTtile.Size = new System.Drawing.Size(107, 25);
            this.laFamilyPopulationTtile.TabIndex = 19;
            this.laFamilyPopulationTtile.Text = "户籍人口：";
            // 
            // laCommunityPopulationValue
            // 
            this.laCommunityPopulationValue.AutoSize = true;
            this.laCommunityPopulationValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunityPopulationValue.Location = new System.Drawing.Point(184, 355);
            this.laCommunityPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunityPopulationValue.Name = "laCommunityPopulationValue";
            this.laCommunityPopulationValue.Size = new System.Drawing.Size(67, 25);
            this.laCommunityPopulationValue.TabIndex = 20;
            this.laCommunityPopulationValue.Text = "00000";
            // 
            // laFamilyPopulationValue
            // 
            this.laFamilyPopulationValue.AutoSize = true;
            this.laFamilyPopulationValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laFamilyPopulationValue.Location = new System.Drawing.Point(422, 355);
            this.laFamilyPopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laFamilyPopulationValue.Name = "laFamilyPopulationValue";
            this.laFamilyPopulationValue.Size = new System.Drawing.Size(67, 25);
            this.laFamilyPopulationValue.TabIndex = 21;
            this.laFamilyPopulationValue.Text = "00000";
            // 
            // laMobilePopulationTtile
            // 
            this.laMobilePopulationTtile.AutoSize = true;
            this.laMobilePopulationTtile.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationTtile.Location = new System.Drawing.Point(514, 355);
            this.laMobilePopulationTtile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationTtile.Name = "laMobilePopulationTtile";
            this.laMobilePopulationTtile.Size = new System.Drawing.Size(107, 25);
            this.laMobilePopulationTtile.TabIndex = 22;
            this.laMobilePopulationTtile.Text = "流动人口：";
            // 
            // laMobilePopulationValue
            // 
            this.laMobilePopulationValue.AutoSize = true;
            this.laMobilePopulationValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMobilePopulationValue.Location = new System.Drawing.Point(656, 355);
            this.laMobilePopulationValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMobilePopulationValue.Name = "laMobilePopulationValue";
            this.laMobilePopulationValue.Size = new System.Drawing.Size(67, 25);
            this.laMobilePopulationValue.TabIndex = 23;
            this.laMobilePopulationValue.Text = "00000";
            // 
            // laCommunistTitle
            // 
            this.laCommunistTitle.AutoSize = true;
            this.laCommunistTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistTitle.Location = new System.Drawing.Point(744, 355);
            this.laCommunistTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistTitle.Name = "laCommunistTitle";
            this.laCommunistTitle.Size = new System.Drawing.Size(69, 25);
            this.laCommunistTitle.TabIndex = 24;
            this.laCommunistTitle.Tag = "m1";
            this.laCommunistTitle.Text = "党员：";
            this.laCommunistTitle.Click += new System.EventHandler(this.laCommunistTitle_Click);
            // 
            // laCommunistValue
            // 
            this.laCommunistValue.AutoSize = true;
            this.laCommunistValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCommunistValue.Location = new System.Drawing.Point(898, 355);
            this.laCommunistValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCommunistValue.Name = "laCommunistValue";
            this.laCommunistValue.Size = new System.Drawing.Size(45, 25);
            this.laCommunistValue.TabIndex = 25;
            this.laCommunistValue.Text = "000";
            this.laCommunistValue.Click += new System.EventHandler(this.laCommunistValue_Click);
            // 
            // laOlderTitle
            // 
            this.laOlderTitle.AutoSize = true;
            this.laOlderTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderTitle.Location = new System.Drawing.Point(50, 412);
            this.laOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderTitle.Name = "laOlderTitle";
            this.laOlderTitle.Size = new System.Drawing.Size(88, 25);
            this.laOlderTitle.TabIndex = 26;
            this.laOlderTitle.Tag = "m2";
            this.laOlderTitle.Text = "老年人：";
            this.laOlderTitle.Click += new System.EventHandler(this.laOlderTitle_Click);
            // 
            // laOlderValue
            // 
            this.laOlderValue.AutoSize = true;
            this.laOlderValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laOlderValue.Location = new System.Drawing.Point(184, 412);
            this.laOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laOlderValue.Name = "laOlderValue";
            this.laOlderValue.Size = new System.Drawing.Size(56, 25);
            this.laOlderValue.TabIndex = 27;
            this.laOlderValue.Text = "0000";
            // 
            // laAloneOlderTitle
            // 
            this.laAloneOlderTitle.AutoSize = true;
            this.laAloneOlderTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderTitle.Location = new System.Drawing.Point(277, 412);
            this.laAloneOlderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderTitle.Name = "laAloneOlderTitle";
            this.laAloneOlderTitle.Size = new System.Drawing.Size(107, 25);
            this.laAloneOlderTitle.TabIndex = 28;
            this.laAloneOlderTitle.Tag = "m3";
            this.laAloneOlderTitle.Text = "空巢老人：";
            this.laAloneOlderTitle.Click += new System.EventHandler(this.laAloneOlderTitle_Click);
            // 
            // laAloneOlderValue
            // 
            this.laAloneOlderValue.AutoSize = true;
            this.laAloneOlderValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laAloneOlderValue.Location = new System.Drawing.Point(422, 412);
            this.laAloneOlderValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laAloneOlderValue.Name = "laAloneOlderValue";
            this.laAloneOlderValue.Size = new System.Drawing.Size(45, 25);
            this.laAloneOlderValue.TabIndex = 29;
            this.laAloneOlderValue.Text = "000";
            // 
            // laHandicappedTitle
            // 
            this.laHandicappedTitle.AutoSize = true;
            this.laHandicappedTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedTitle.Location = new System.Drawing.Point(514, 412);
            this.laHandicappedTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedTitle.Name = "laHandicappedTitle";
            this.laHandicappedTitle.Size = new System.Drawing.Size(88, 25);
            this.laHandicappedTitle.TabIndex = 30;
            this.laHandicappedTitle.Tag = "m4";
            this.laHandicappedTitle.Text = "残疾人：";
            this.laHandicappedTitle.Click += new System.EventHandler(this.laHandicappedTitle_Click);
            // 
            // laMentalTitle
            // 
            this.laMentalTitle.AutoSize = true;
            this.laMentalTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalTitle.Location = new System.Drawing.Point(744, 412);
            this.laMentalTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalTitle.Name = "laMentalTitle";
            this.laMentalTitle.Size = new System.Drawing.Size(107, 25);
            this.laMentalTitle.TabIndex = 31;
            this.laMentalTitle.Tag = "m5";
            this.laMentalTitle.Text = "精神残疾：";
            this.laMentalTitle.Click += new System.EventHandler(this.laMentalTitle_Click);
            // 
            // laHandicappedValue
            // 
            this.laHandicappedValue.AutoSize = true;
            this.laHandicappedValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laHandicappedValue.Location = new System.Drawing.Point(656, 412);
            this.laHandicappedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laHandicappedValue.Name = "laHandicappedValue";
            this.laHandicappedValue.Size = new System.Drawing.Size(45, 25);
            this.laHandicappedValue.TabIndex = 32;
            this.laHandicappedValue.Text = "000";
            // 
            // laMentalValue
            // 
            this.laMentalValue.AutoSize = true;
            this.laMentalValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laMentalValue.Location = new System.Drawing.Point(898, 412);
            this.laMentalValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laMentalValue.Name = "laMentalValue";
            this.laMentalValue.Size = new System.Drawing.Size(45, 25);
            this.laMentalValue.TabIndex = 33;
            this.laMentalValue.Text = "000";
            // 
            // laPriorityTitle
            // 
            this.laPriorityTitle.AutoSize = true;
            this.laPriorityTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityTitle.Location = new System.Drawing.Point(31, 465);
            this.laPriorityTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityTitle.Name = "laPriorityTitle";
            this.laPriorityTitle.Size = new System.Drawing.Size(107, 25);
            this.laPriorityTitle.TabIndex = 34;
            this.laPriorityTitle.Tag = "m6";
            this.laPriorityTitle.Text = "优抚对象：";
            this.laPriorityTitle.Click += new System.EventHandler(this.laPriorityTitle_Click);
            // 
            // laPriorityValue
            // 
            this.laPriorityValue.AutoSize = true;
            this.laPriorityValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laPriorityValue.Location = new System.Drawing.Point(422, 517);
            this.laPriorityValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laPriorityValue.Name = "laPriorityValue";
            this.laPriorityValue.Size = new System.Drawing.Size(45, 25);
            this.laPriorityValue.TabIndex = 35;
            this.laPriorityValue.Text = "000";
            // 
            // laForeignerTitle
            // 
            this.laForeignerTitle.AutoSize = true;
            this.laForeignerTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerTitle.Location = new System.Drawing.Point(277, 465);
            this.laForeignerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerTitle.Name = "laForeignerTitle";
            this.laForeignerTitle.Size = new System.Drawing.Size(107, 25);
            this.laForeignerTitle.TabIndex = 36;
            this.laForeignerTitle.Tag = "m7";
            this.laForeignerTitle.Text = "境外人员：";
            this.laForeignerTitle.Click += new System.EventHandler(this.laForeignerTitle_Click);
            // 
            // laForeignerValue
            // 
            this.laForeignerValue.AutoSize = true;
            this.laForeignerValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laForeignerValue.Location = new System.Drawing.Point(422, 465);
            this.laForeignerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laForeignerValue.Name = "laForeignerValue";
            this.laForeignerValue.Size = new System.Drawing.Size(45, 25);
            this.laForeignerValue.TabIndex = 37;
            this.laForeignerValue.Text = "000";
            // 
            // laLowestFmailyTitle
            // 
            this.laLowestFmailyTitle.AutoSize = true;
            this.laLowestFmailyTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyTitle.Location = new System.Drawing.Point(514, 465);
            this.laLowestFmailyTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyTitle.Name = "laLowestFmailyTitle";
            this.laLowestFmailyTitle.Size = new System.Drawing.Size(107, 25);
            this.laLowestFmailyTitle.TabIndex = 38;
            this.laLowestFmailyTitle.Tag = "m8";
            this.laLowestFmailyTitle.Text = "低保户数：";
            this.laLowestFmailyTitle.Click += new System.EventHandler(this.laLowestFmailyTitle_Click);
            // 
            // laLowestFmailyValue
            // 
            this.laLowestFmailyValue.AutoSize = true;
            this.laLowestFmailyValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestFmailyValue.Location = new System.Drawing.Point(656, 465);
            this.laLowestFmailyValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestFmailyValue.Name = "laLowestFmailyValue";
            this.laLowestFmailyValue.Size = new System.Drawing.Size(45, 25);
            this.laLowestFmailyValue.TabIndex = 39;
            this.laLowestFmailyValue.Text = "000";
            // 
            // laLowestPeopleTitle
            // 
            this.laLowestPeopleTitle.AutoSize = true;
            this.laLowestPeopleTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleTitle.Location = new System.Drawing.Point(744, 465);
            this.laLowestPeopleTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleTitle.Name = "laLowestPeopleTitle";
            this.laLowestPeopleTitle.Size = new System.Drawing.Size(107, 25);
            this.laLowestPeopleTitle.TabIndex = 40;
            this.laLowestPeopleTitle.Tag = "m9";
            this.laLowestPeopleTitle.Text = "低保人员：";
            this.laLowestPeopleTitle.Click += new System.EventHandler(this.laLowestPeopleTitle_Click);
            // 
            // laLowestPeopleValue
            // 
            this.laLowestPeopleValue.AutoSize = true;
            this.laLowestPeopleValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laLowestPeopleValue.Location = new System.Drawing.Point(898, 465);
            this.laLowestPeopleValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laLowestPeopleValue.Name = "laLowestPeopleValue";
            this.laLowestPeopleValue.Size = new System.Drawing.Size(45, 25);
            this.laLowestPeopleValue.TabIndex = 41;
            this.laLowestPeopleValue.Text = "000";
            // 
            // laCleanerTitle
            // 
            this.laCleanerTitle.AutoSize = true;
            this.laCleanerTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerTitle.Location = new System.Drawing.Point(31, 517);
            this.laCleanerTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerTitle.Name = "laCleanerTitle";
            this.laCleanerTitle.Size = new System.Drawing.Size(107, 25);
            this.laCleanerTitle.TabIndex = 42;
            this.laCleanerTitle.Tag = "m10";
            this.laCleanerTitle.Text = "保洁人员：";
            this.laCleanerTitle.Click += new System.EventHandler(this.laCleanerTitle_Click);
            // 
            // laCleanerValue
            // 
            this.laCleanerValue.AutoSize = true;
            this.laCleanerValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCleanerValue.Location = new System.Drawing.Point(184, 517);
            this.laCleanerValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCleanerValue.Name = "laCleanerValue";
            this.laCleanerValue.Size = new System.Drawing.Size(45, 25);
            this.laCleanerValue.TabIndex = 43;
            this.laCleanerValue.Text = "000";
            // 
            // laEmphasisTitle
            // 
            this.laEmphasisTitle.AutoSize = true;
            this.laEmphasisTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisTitle.Location = new System.Drawing.Point(277, 517);
            this.laEmphasisTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisTitle.Name = "laEmphasisTitle";
            this.laEmphasisTitle.Size = new System.Drawing.Size(107, 25);
            this.laEmphasisTitle.TabIndex = 44;
            this.laEmphasisTitle.Tag = "m11";
            this.laEmphasisTitle.Text = "重点人员：";
            this.laEmphasisTitle.Click += new System.EventHandler(this.laEmphasisTitle_Click);
            // 
            // laEmphasisValue
            // 
            this.laEmphasisValue.AutoSize = true;
            this.laEmphasisValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laEmphasisValue.Location = new System.Drawing.Point(184, 465);
            this.laEmphasisValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laEmphasisValue.Name = "laEmphasisValue";
            this.laEmphasisValue.Size = new System.Drawing.Size(45, 25);
            this.laEmphasisValue.TabIndex = 45;
            this.laEmphasisValue.Text = "000";
            // 
            // laUnemploymentTitle
            // 
            this.laUnemploymentTitle.AutoSize = true;
            this.laUnemploymentTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentTitle.Location = new System.Drawing.Point(514, 517);
            this.laUnemploymentTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentTitle.Name = "laUnemploymentTitle";
            this.laUnemploymentTitle.Size = new System.Drawing.Size(107, 25);
            this.laUnemploymentTitle.TabIndex = 46;
            this.laUnemploymentTitle.Tag = "m12";
            this.laUnemploymentTitle.Text = "失业人员：";
            this.laUnemploymentTitle.Click += new System.EventHandler(this.laUnemploymentTitle_Click);
            // 
            // laUnemploymentValue
            // 
            this.laUnemploymentValue.AutoSize = true;
            this.laUnemploymentValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laUnemploymentValue.Location = new System.Drawing.Point(656, 517);
            this.laUnemploymentValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laUnemploymentValue.Name = "laUnemploymentValue";
            this.laUnemploymentValue.Size = new System.Drawing.Size(45, 25);
            this.laUnemploymentValue.TabIndex = 47;
            this.laUnemploymentValue.Text = "000";
            // 
            // laDopeTitle
            // 
            this.laDopeTitle.AutoSize = true;
            this.laDopeTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeTitle.Location = new System.Drawing.Point(744, 517);
            this.laDopeTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeTitle.Name = "laDopeTitle";
            this.laDopeTitle.Size = new System.Drawing.Size(107, 25);
            this.laDopeTitle.TabIndex = 48;
            this.laDopeTitle.Tag = "m13";
            this.laDopeTitle.Text = "吸毒人员：";
            this.laDopeTitle.Click += new System.EventHandler(this.laDopeTitle_Click);
            // 
            // laDopeValue
            // 
            this.laDopeValue.AutoSize = true;
            this.laDopeValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laDopeValue.Location = new System.Drawing.Point(898, 517);
            this.laDopeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laDopeValue.Name = "laDopeValue";
            this.laDopeValue.Size = new System.Drawing.Size(45, 25);
            this.laDopeValue.TabIndex = 49;
            this.laDopeValue.Text = "000";
            // 
            // laCorrectTitle
            // 
            this.laCorrectTitle.AutoSize = true;
            this.laCorrectTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectTitle.Location = new System.Drawing.Point(31, 571);
            this.laCorrectTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectTitle.Name = "laCorrectTitle";
            this.laCorrectTitle.Size = new System.Drawing.Size(107, 25);
            this.laCorrectTitle.TabIndex = 50;
            this.laCorrectTitle.Tag = "m14";
            this.laCorrectTitle.Text = "矫正人员：";
            this.laCorrectTitle.Click += new System.EventHandler(this.laCorrectTitle_Click);
            // 
            // laCorrectValue
            // 
            this.laCorrectValue.AutoSize = true;
            this.laCorrectValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laCorrectValue.Location = new System.Drawing.Point(184, 571);
            this.laCorrectValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laCorrectValue.Name = "laCorrectValue";
            this.laCorrectValue.Size = new System.Drawing.Size(45, 25);
            this.laCorrectValue.TabIndex = 51;
            this.laCorrectValue.Text = "000";
            // 
            // laReleaseTitle
            // 
            this.laReleaseTitle.AutoSize = true;
            this.laReleaseTitle.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseTitle.Location = new System.Drawing.Point(277, 571);
            this.laReleaseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseTitle.Name = "laReleaseTitle";
            this.laReleaseTitle.Size = new System.Drawing.Size(107, 25);
            this.laReleaseTitle.TabIndex = 52;
            this.laReleaseTitle.Tag = "m15";
            this.laReleaseTitle.Text = "刑释人员：";
            this.laReleaseTitle.Click += new System.EventHandler(this.laReleaseTitle_Click);
            // 
            // laReleaseValue
            // 
            this.laReleaseValue.AutoSize = true;
            this.laReleaseValue.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laReleaseValue.Location = new System.Drawing.Point(422, 571);
            this.laReleaseValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laReleaseValue.Name = "laReleaseValue";
            this.laReleaseValue.Size = new System.Drawing.Size(45, 25);
            this.laReleaseValue.TabIndex = 53;
            this.laReleaseValue.Text = "000";
            // 
            // gbListMain
            // 
            this.gbListMain.BackColor = System.Drawing.Color.White;
            this.gbListMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbListMain.BackgroundImage")));
            this.gbListMain.Controls.Add(this.laReleaseValue);
            this.gbListMain.Controls.Add(this.laReleaseTitle);
            this.gbListMain.Controls.Add(this.laCorrectValue);
            this.gbListMain.Controls.Add(this.laCorrectTitle);
            this.gbListMain.Controls.Add(this.laDopeValue);
            this.gbListMain.Controls.Add(this.laDopeTitle);
            this.gbListMain.Controls.Add(this.laUnemploymentValue);
            this.gbListMain.Controls.Add(this.laUnemploymentTitle);
            this.gbListMain.Controls.Add(this.laEmphasisValue);
            this.gbListMain.Controls.Add(this.laEmphasisTitle);
            this.gbListMain.Controls.Add(this.laCleanerValue);
            this.gbListMain.Controls.Add(this.laCleanerTitle);
            this.gbListMain.Controls.Add(this.laLowestPeopleValue);
            this.gbListMain.Controls.Add(this.laLowestPeopleTitle);
            this.gbListMain.Controls.Add(this.laLowestFmailyValue);
            this.gbListMain.Controls.Add(this.laLowestFmailyTitle);
            this.gbListMain.Controls.Add(this.laForeignerValue);
            this.gbListMain.Controls.Add(this.laForeignerTitle);
            this.gbListMain.Controls.Add(this.laPriorityValue);
            this.gbListMain.Controls.Add(this.laPriorityTitle);
            this.gbListMain.Controls.Add(this.laMentalValue);
            this.gbListMain.Controls.Add(this.laHandicappedValue);
            this.gbListMain.Controls.Add(this.laMentalTitle);
            this.gbListMain.Controls.Add(this.laHandicappedTitle);
            this.gbListMain.Controls.Add(this.laAloneOlderValue);
            this.gbListMain.Controls.Add(this.laAloneOlderTitle);
            this.gbListMain.Controls.Add(this.laOlderValue);
            this.gbListMain.Controls.Add(this.laOlderTitle);
            this.gbListMain.Controls.Add(this.laCommunistValue);
            this.gbListMain.Controls.Add(this.laCommunistTitle);
            this.gbListMain.Controls.Add(this.laMobilePopulationValue);
            this.gbListMain.Controls.Add(this.laMobilePopulationTtile);
            this.gbListMain.Controls.Add(this.laFamilyPopulationValue);
            this.gbListMain.Controls.Add(this.laCommunityPopulationValue);
            this.gbListMain.Controls.Add(this.laFamilyPopulationTtile);
            this.gbListMain.Controls.Add(this.laCommunityPopulationTitle);
            this.gbListMain.Controls.Add(this.laUnitValue);
            this.gbListMain.Controls.Add(this.laUnitTitle);
            this.gbListMain.Controls.Add(this.laHouseValue);
            this.gbListMain.Controls.Add(this.laHouseTitle);
            this.gbListMain.Controls.Add(this.laFamilyValue);
            this.gbListMain.Controls.Add(this.laFamilyTitle);
            this.gbListMain.Controls.Add(this.laYardValue);
            this.gbListMain.Controls.Add(this.laYardTitle);
            this.gbListMain.Controls.Add(this.laFLL);
            this.gbListMain.Controls.Add(this.laQTL);
            this.gbListMain.Controls.Add(this.laCTL);
            this.gbListMain.Controls.Add(this.laSXQ);
            this.gbListMain.Controls.Add(this.laNetRange);
            this.gbListMain.Controls.Add(this.laBgszrName);
            this.gbListMain.Controls.Add(this.laBgszrTitle);
            this.gbListMain.Controls.Add(this.laDgwsjName);
            this.gbListMain.Controls.Add(this.laDgwsjTitle);
            this.gbListMain.Controls.Add(this.laTitle1);
            this.gbListMain.Location = new System.Drawing.Point(0, 11);
            this.gbListMain.Margin = new System.Windows.Forms.Padding(2);
            this.gbListMain.Name = "gbListMain";
            this.gbListMain.Padding = new System.Windows.Forms.Padding(2);
            this.gbListMain.Size = new System.Drawing.Size(1008, 707);
            this.gbListMain.TabIndex = 0;
            this.gbListMain.TabStop = false;
            this.gbListMain.Tag = "0";
            // 
            // ListMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbListMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "列表查看-总表";
            this.Load += new System.EventHandler(this.ListMainForm_Load);
            this.gbListMain.ResumeLayout(false);
            this.gbListMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laTitle1;
        private System.Windows.Forms.Label laDgwsjTitle;
        private System.Windows.Forms.Label laDgwsjName;
        private System.Windows.Forms.Label laBgszrTitle;
        private System.Windows.Forms.Label laBgszrName;
        private System.Windows.Forms.Label laNetRange;
        private System.Windows.Forms.Label laSXQ;
        private System.Windows.Forms.Label laCTL;
        private System.Windows.Forms.Label laQTL;
        private System.Windows.Forms.Label laFLL;
        private System.Windows.Forms.Label laYardTitle;
        private System.Windows.Forms.Label laYardValue;
        private System.Windows.Forms.Label laFamilyTitle;
        private System.Windows.Forms.Label laFamilyValue;
        private System.Windows.Forms.Label laHouseTitle;
        private System.Windows.Forms.Label laHouseValue;
        private System.Windows.Forms.Label laUnitTitle;
        private System.Windows.Forms.Label laUnitValue;
        private System.Windows.Forms.Label laCommunityPopulationTitle;
        private System.Windows.Forms.Label laFamilyPopulationTtile;
        private System.Windows.Forms.Label laCommunityPopulationValue;
        private System.Windows.Forms.Label laFamilyPopulationValue;
        private System.Windows.Forms.Label laMobilePopulationTtile;
        private System.Windows.Forms.Label laMobilePopulationValue;
        private System.Windows.Forms.Label laCommunistTitle;
        private System.Windows.Forms.Label laCommunistValue;
        private System.Windows.Forms.Label laOlderTitle;
        private System.Windows.Forms.Label laOlderValue;
        private System.Windows.Forms.Label laAloneOlderTitle;
        private System.Windows.Forms.Label laAloneOlderValue;
        private System.Windows.Forms.Label laHandicappedTitle;
        private System.Windows.Forms.Label laMentalTitle;
        private System.Windows.Forms.Label laHandicappedValue;
        private System.Windows.Forms.Label laMentalValue;
        private System.Windows.Forms.Label laPriorityTitle;
        private System.Windows.Forms.Label laPriorityValue;
        private System.Windows.Forms.Label laForeignerTitle;
        private System.Windows.Forms.Label laForeignerValue;
        private System.Windows.Forms.Label laLowestFmailyTitle;
        private System.Windows.Forms.Label laLowestFmailyValue;
        private System.Windows.Forms.Label laLowestPeopleTitle;
        private System.Windows.Forms.Label laLowestPeopleValue;
        private System.Windows.Forms.Label laCleanerTitle;
        private System.Windows.Forms.Label laCleanerValue;
        private System.Windows.Forms.Label laEmphasisTitle;
        private System.Windows.Forms.Label laEmphasisValue;
        private System.Windows.Forms.Label laUnemploymentTitle;
        private System.Windows.Forms.Label laUnemploymentValue;
        private System.Windows.Forms.Label laDopeTitle;
        private System.Windows.Forms.Label laDopeValue;
        private System.Windows.Forms.Label laCorrectTitle;
        private System.Windows.Forms.Label laCorrectValue;
        private System.Windows.Forms.Label laReleaseTitle;
        private System.Windows.Forms.Label laReleaseValue;
        private System.Windows.Forms.GroupBox gbListMain;
    }
}