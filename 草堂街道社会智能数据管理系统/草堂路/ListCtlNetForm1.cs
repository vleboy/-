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

namespace 草堂街道社会智能数据管理系统.草堂路
{
    public partial class ListCtlNetForm1 : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public ListCtlNetForm1()
        {
            InitializeComponent();
        }

        private void laTitle_Click(object sender, EventArgs e)
        {

        }

        private void ListCtlNetForm1_Load(object sender, EventArgs e)
        {
            laYardValue.Text = db.GetSingleObject("SELECT Count(population.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = '1'").ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE residentaddresss.`host` = '1'").ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = '1'").ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT Count(resident.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id WHERE district.id = '1'").ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
            laCommunistValue.Text = db.GetSingleObject("SELECT Count(population.educational) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE district.id = '1' AND population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT Count(features.old) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = '1' ").ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT Count(features.old_alone) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = '1' AND features.old_alone = '1'").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE district.id = '1'").ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE district.id = '1' AND handicapped.handicapped_type = 0").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE district.id = '1'").ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE district.id = '1'").ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE district.id = '1'").ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT Count(features.cleaner) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = '1' AND features.cleaner = '1'").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT Count(features.vip) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE district.id = '1' AND features.vip = '1'").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN unjob ON features.unjob = unjob.id WHERE district.id = '1'").ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN dope ON features.dope = dope.id WHERE district.id = '1'").ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN correction ON features.correction = correction.id WHERE district.id = '1' ").ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN released ON features.released = released.id WHERE district.id = '1' ").ToString();
        }

        private void laYardGroundValue4_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laYardGroundValue1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCommunistTitle_Click(object sender, EventArgs e)
        {

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
    }
}
