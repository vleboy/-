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
    public partial class ListCtlNetBlockPersonForm : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        string sqlcmd_sum = "SELECT count(block) FROM population WHERE block = 1";
        string sqlcmd_preson = "SELECT count(id) FROM population WHERE block = 1 AND features IS NULL";
        string sqlcmd_resident = "SELECT count(a.id) FROM features AS a, population  AS b WHERE  b.block = 1 AND a.id = b.features AND a.resident IS NOT NULL ";
        string sqlcmd_handicapped = "SELECT COUNT(a.id) FROM features AS a, population  AS b WHERE  b.block = 1 AND a.id = b.features AND a.handicapped IS NOT NULL ";
        string sqlcmd_handicapped_mental = "SELECT COUNT(a.id) FROM handicapped AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.handicapped_type = '1'";
        string sqlcmd_foreigner = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.foreigner IS NOT NULL";
        string sqlcmd_old = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.old IS NOT NULL";
        string sqlcmd_oldalone = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.old_alone IS NOT NULL";
        string sqlcmd_poor = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.poor IS NOT NULL";
        string sqlcmd_correction = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.correction IS NOT NULL";
        string sqlcmd_released = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.released IS NOT NULL";
        string sqlcmd_dope = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.dope IS NOT NULL";
        string sqlcmd_gdv_preson = "SELECT * ,case gender when true then '男' when false then '女' end as sex FROM  population WHERE block = 1 AND features IS NULL";
        string sqlcmd_gdv_resident = "SELECT population.`name`,population.age,population.card_id,population.address,population.gender,population.census_address,population.note,population.educational,resident.resident_addresss,resident.tenants,resident.photo,resident.registration_date,resident.now_date,resident.ethnic FROM features INNER JOIN population ON population.features = features.id INNER JOIN resident ON features.resident = resident.id";
        string sqlcmd_gdv_handicapped = "SELECT handicapped.ethnic, handicapped.handicapped_id, handicapped.handicapped_type, handicapped.handicapped_level, handicapped.guardian_name, handicapped.guardian_relationship, population.card_id, population.`name`, population.age, population.address, population.gender, population.census_address, population.educational, population.note FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN handicapped ON features.handicapped = handicapped.id";
        string sqlcmd_gdv_foreigner = "SELECT population.card_id, population.`name`, population.age, population.address, population.gender, population.census_address, population.educational, population.note, foreigner.citizenship, foreigner.card_id, foreigner.card_date, foreigner.card_type, foreigner.house_belongs, foreigner.registration_date, foreigner.contact, foreigner.associates, foreigner.associates_phone, foreigner.isforever, foreigner.leave_date FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN foreigner ON features.foreigner = foreigner.id WHERE block.id = '1'";
        string sqlcmd_gdv_poor = "SELECT poor.poorid FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN poor ON features.poor = poor.id WHERE block.id = 1 ";
        string sqlcmd_gdv_correction = "SELECT correction.criminal, correction.criminal_type, correction.criminal_period, correction.correction_firstdate, correction.correction_enddate, correction.correction_type, correction.school_or_job FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN correction ON features.correction = correction.id WHERE block.id = 1 ";
        string sqlcmd_gdv_released = "SELECT released.criminal, released.criminal_start_date, released.criminal_end_date, released.prison_address, released.free_date FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN released ON features.released = released.id WHERE block.id = 1 ";
        string sqlcmd_gdv_dope = "SELECT dope.police_address, dope.first_date, dope.dope_type, dope.`status` FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id INNER JOIN dope ON features.dope = dope.id WHERE block.id = 1 ";
        string sqlcmd_gdv_old = " SELECT population.card_id, population.`name`, population.age, population.address, population.gender, population.census_address, population.block, population.note, population.educational, population.features FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id WHERE block.id = 1 AND features.old = 1  ";
        public ListCtlNetBlockPersonForm()
        {
            InitializeComponent();
        }
        private string returnSqlCmd(string sqlcmd,string block)
        {
            return sqlcmd.Replace("block = 1", "block = " + block);
        }
        private  void viewgdv(string cmdnum)
        {
            lasum.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_sum,cmdnum)).ToString();
            lapreson.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_preson, cmdnum)).ToString();
            laresident.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_resident, cmdnum)).ToString();
            lahandicapped.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_handicapped, cmdnum)).ToString();
            lamental.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_handicapped_mental, cmdnum)).ToString();
            laforeigner.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_foreigner, cmdnum)).ToString();
            laold.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_old, cmdnum)).ToString();
            laalone.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_oldalone, cmdnum)).ToString();
            lapoor.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_poor, cmdnum)).ToString();
            lacorrection.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_correction, cmdnum)).ToString();
            lareleased.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_released, cmdnum)).ToString();
            ladope.Text = db.GetSingleObject(returnSqlCmd(sqlcmd_dope, cmdnum)).ToString();          
            dataGridView1.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_preson, cmdnum), "t").Tables["t"];
            dataGridView2.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_resident, cmdnum), "t").Tables["t"];
            dataGridView3.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_handicapped, cmdnum), "t").Tables["t"];
            dataGridView4.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_old, cmdnum), "t").Tables["t"];
            dataGridView5.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_foreigner, cmdnum), "t").Tables["t"];
            dataGridView6.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_poor, cmdnum), "t").Tables["t"];
            dataGridView7.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_correction, cmdnum), "t").Tables["t"];
            dataGridView8.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_released, cmdnum), "t").Tables["t"];
            dataGridView9.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_dope, cmdnum), "t").Tables["t"];
        }
        private void ListCtlNetBlockPersonForm_Load(object sender, EventArgs e)
        {
            string strresident = "SELECT district.`name` FROM district WHERE district.id =";
            string strblock = "SELECT block.`name` FROM block WHERE block.id = ";
            string strgrid = " SELECT grid.`name` FROM grid WHERE grid.id =";
            laresident.Text = db.GetSingleObject(strresident + resident.ToString()).ToString();
            lagrid.Text = db.GetSingleObject(strgrid + resident.ToString()).ToString();
            lablock.Text = db.GetSingleObject(strblock + resident.ToString()).ToString();
            viewgdv(block.ToString());
                              
           
        }
    }
}
