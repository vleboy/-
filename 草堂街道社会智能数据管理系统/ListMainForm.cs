using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.ComClass;
using 草堂街道社会智能数据管理系统.dataClass;

namespace 草堂街道社会智能数据管理系统
{
    public partial class ListMainForm : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public ListMainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void laCommunistValue_Click(object sender, EventArgs e)
        {

        }

        private void ListMainForm_Load(object sender, EventArgs e)
        {
            //  MySqlHelper.ExecuteScalar()
            laYardValue.Text = db.GetSingleObject("SELECT COUNT(id) FROM block").ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT COUNT(residentaddresss.`host`) FROM residentaddresss WHERE residentaddresss.`host` = 1").ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT COUNT(population.`name`) FROM population").ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT count(resident.id) FROM resident").ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
            laCommunistValue.Text = db.GetSingleObject("SELECT count(population.educational) FROM population WHERE population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.old IS NOT NULL").ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.old_alone = 1 ").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT count(handicapped.id) FROM handicapped").ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT count(handicapped.id) FROM handicapped WHERE handicapped.handicapped_type = '精神'").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT count(poor.id) FROM poor").ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.`host`)" +
            "FROM poor INNER JOIN features ON features.poor = poor.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE poor.poorid IS NOT NULL").ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT count(poor.id) FROM poor").ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.cleaner IS NOT NULL").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT COUNT(features.id) FROM features WHERE features.vip IS NOT NULL").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM unjob").ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM dope").ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM correction").ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM released").ToString();




        }

        private void laSXQ_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCTL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laQTL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laFLL_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCommunistTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laHandicappedTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }
    }
}
