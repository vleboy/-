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

namespace 草堂街道社会智能数据管理系统.琴台路
{
    public partial class ListQtlNetForm2 : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public ListQtlNetForm2()
        {
            InitializeComponent();
        }

        private void laTitle_Click(object sender, EventArgs e)
        {

        }

        private void laYardGroundValue1_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void ListQtlNetForm2_Load(object sender, EventArgs e)
        {
            laResponsibleValue.Text = db.GetSingleObject("SELECT blockmanager.manager FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.`name` = '琴台路第二网格' ").ToString();
            laPoliceValue.Text = db.GetSingleObject("SELECT blockmanager.police FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.`name` = '琴台路第二网格' ").ToString();
            laResponsibleTelValue.Text = db.GetSingleObject("SELECT blockmanager.manager_code FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.`name` = '琴台路第二网格' ").ToString();
            laPolicePhoneValue.Text = db.GetSingleObject("SELECT blockmanager.police_phone FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.`name` = '琴台路第二网格'  ").ToString();
            laResponsiblePhoneValue.Text = db.GetSingleObject("SELECT blockmanager.manager_phone FROM grid INNER JOIN block ON block.grid = grid.id INNER JOIN blockmanager ON grid.block_manager = blockmanager.id AND block.block_manager = blockmanager.id WHERE grid.`name` = '琴台路第二网格'  ").ToString();

            laYardValue.Text = db.GetSingleObject("SELECT Count(population.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laFamilyValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE residentaddresss.`host` = '1' AND grid.`name` = '琴台路第二网格'").ToString();
            laCommunityPopulationValue.Text = db.GetSingleObject("SELECT Count(population.`name`) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laFamilyPopulationValue.Text = db.GetSingleObject("SELECT Count(resident.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laMobilePopulationValue.Text = (Convert.ToUInt16(laCommunityPopulationValue.Text) - Convert.ToUInt16(laFamilyPopulationValue.Text)).ToString();
            laCommunistValue.Text = db.GetSingleObject("SELECT Count(population.educational) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id WHERE  grid.`name` = '琴台路第二网格' AND population.educational = '党员'").ToString();
            laOlderValue.Text = db.GetSingleObject("SELECT Count(features.old) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE  grid.`name` = '琴台路第二网格' ").ToString();
            laAloneOlderValue.Text = db.GetSingleObject("SELECT Count(features.old_alone) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE  grid.`name` = '琴台路第二网格' AND features.old_alone = '1'").ToString();
            laHandicappedValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laMentalValue.Text = db.GetSingleObject("SELECT Count(handicapped.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id WHERE  grid.`name` = '琴台路第二网格' AND handicapped.handicapped_type = 0").ToString();
            laEmphasisValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laForeignerValue.Text = db.GetSingleObject("SELECT count(foreigner.id) FROM foreigner").ToString();
            laLowestFmailyValue.Text = db.GetSingleObject("SELECT Count(residentaddresss.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN resident ON features.resident = resident.id INNER JOIN residentaddresss ON resident.resident_addresss = residentaddresss.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laLowestPeopleValue.Text = db.GetSingleObject("SELECT Count(poor.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laCleanerValue.Text = db.GetSingleObject("SELECT Count(features.cleaner) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE  grid.`name` = '琴台路第二网格' AND features.cleaner = '1'").ToString();
            laPriorityValue.Text = db.GetSingleObject("SELECT Count(features.vip) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE  grid.`name` = '琴台路第二网格' AND features.vip = '1'").ToString();
            laUnemploymentValue.Text = db.GetSingleObject("SELECT Count(unjob.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN unjob ON features.unjob = unjob.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laDopeValue.Text = db.GetSingleObject("SELECT Count(dope.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN dope ON features.dope = dope.id WHERE  grid.`name` = '琴台路第二网格'").ToString();
            laCorrectValue.Text = db.GetSingleObject("SELECT Count(correction.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN correction ON features.correction = correction.id WHERE  grid.`name` = '琴台路第二网格' ").ToString();
            laReleaseValue.Text = db.GetSingleObject("SELECT Count(released.id) FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN released ON features.released = released.id WHERE  grid.`name` = '琴台路第二网格' ").ToString();

        }

        private void laCommunistTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laOlderTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laAloneOlderTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laHandicappedTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laMentalTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laPriorityTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laForeignerTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laLowestFmailyTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laLowestPeopleTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCleanerTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laEmphasisTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laUnemploymentTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laDopeTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laCorrectTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }

        private void laReleaseTitle_Click(object sender, EventArgs e)
        {
            CommonUse commUse = new CommonUse();
            commUse.ShowForm((Label)sender, this.main);
        }
    }
}
