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
    public partial class ppmanager : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
 

        public ppmanager()
        {
            InitializeComponent();
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 添加人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            CommonUse commUse = new CommonUse();
            var x = (ToolStripMenuItem)sender;

            commUse.ShowForm(x.Tag.ToString(), this.main);
        }

        private void ppmanager_Load(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT district.`name` AS nd, grid.`name` AS ng, block.`name` AS nb, population.card_id AS cid, population.`name` AS na,population.address AS ad, "
           + "CASE population.educational WHEN '党员' THEN '是' ELSE '否' end AS edu,"
           + "CASE features.vip when true then '是' ELSE '否'end AS vip,"
            + "CASE features.cleaner when true then '是' ELSE '否'end AS cle,"
            + "CASE features.old when true then '是' ELSE '否'end AS old,"
            + "CASE features.old_alone when true then '是' ELSE '否'end AS olda,"
            + "CASE features.poor when poor then '是' ELSE '否'end AS poor,"
            + "CASE features.handicapped when handicapped then '是' ELSE '否'end AS hand,"
            + "CASE features.resident when resident then '是' ELSE '否'end AS res,"
            + "CASE features.unjob when unjob then '是' ELSE '否'end AS unjob,"
            + "CASE features.dope when dope then '是' ELSE '否'end AS dope,"
            + "CASE features.correction when correction then '是' ELSE '否'end AS cor,"
            + "CASE features.released when released then '是' ELSE '否'end AS rel,"
            + "CASE features.foreigner when foreigner then '是' ELSE '否'end AS fore FROM district INNER JOIN grid ON grid.district = district.id INNER JOIN block ON block.grid = grid.id INNER JOIN population ON population.block = block.id INNER JOIN features ON population.features = features.id ";
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sssq_cb.DataSource = items;
            //   items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            sswg_cb.DataSource = items;
            //  items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            ssyl_cb.DataSource = items;
            //  items.Clear();
            sdr.Close();
            
            if (this.Tag.ToString() != null)
            {

                string s = this.Tag.ToString();
                switch (this.Tag.ToString())
                {
                    

                    case "m1":
                        {
                            sqlcmd += "WHERE population.educational = '党员' AND  district.id = '1'";
                        }
                        break;
                    case "m2":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL";
                        }
                        break;
                    case "m3":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 ";
                        }
                        break;
                    case "m4":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "m5":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1";
                        }
                        break;
                    case "m6":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m7":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1";
                        }
                        break;
                    case "m8":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m9":
                        {
                            sqlcmd += "WHERE features.poor >= 1";
                        }
                        break;
                    case "m10":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 ";
                        }
                        break;
                    case "m11":
                        {
                            sqlcmd += "WHERE features.vip >= 1";
                        }
                        break;
                    case "m12":
                        {
                            sqlcmd += "WHERE features.unjob >= 1";
                        }
                        break;
                    case "m13":
                        {
                            sqlcmd += "WHERE features.dope >= 1";
                        }
                        break;
                    case "m14":
                        {
                            sqlcmd += "WHERE features.correction >= 1";
                        }
                        break;
                    case "m15":
                        {
                            sqlcmd += "WHERE features.released >= 1";
                        }
                        break;
                    case "m101":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1'";
                        }
                        break;
                    case "m102":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1'";
                        }
                        break;
                    case "m103":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m104":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m105":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m106":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m107":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m108":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m109":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m110":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m111":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m112":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m113":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m114":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1'";
                        }
                        break;
                    case "m115":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1'";
                        }
                        break;


                    case "m201":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2'";
                        }
                        break;
                    case "m202":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2'";
                        }
                        break;
                    case "m203":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m204":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m205":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m206":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m207":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m208":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m209":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m210":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m211":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m212":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m213":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m214":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2'";
                        }
                        break;
                    case "m215":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2'";
                        }
                        break;


                    case "m301":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3'";
                        }
                        break;
                    case "m302":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3'";
                        }
                        break;
                    case "m303":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m304":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m305":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m306":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m307":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m308":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m309":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m310":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m311":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m312":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m313":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m314":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3'";
                        }
                        break;
                    case "m315":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3'";
                        }
                        break;


                    case "m401":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4'";
                        }
                        break;
                    case "m402":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4'";
                        }
                        break;
                    case "m403":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m404":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m405":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m406":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m407":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m408":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m409":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m410":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m411":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m412":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m413":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m414":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4'";
                        }
                        break;
                    case "m415":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4'";
                        }
                        break;


                    case "m10101":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10102":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10103":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10104":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10105":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10106":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10107":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10108":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10109":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10110":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10111":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10112":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10113":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10114":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10115":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第一网格'";
                        }
                        break;
                    case "m10201":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10202":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10203":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10204":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10205":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10206":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10207":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10208":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10209":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10210":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10211":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10212":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10213":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10214":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10215":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第二网格'";
                        }
                        break;
                    case "m10301":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10302":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10303":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10304":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10305":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10306":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10307":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10308":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10309":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10310":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10311":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10312":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10313":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10314":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10315":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第三网格'";
                        }
                        break;
                    case "m10401":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10402":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10403":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10404":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10405":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10406":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10407":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10408":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10409":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10410":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10411":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10412":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10413":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10414":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;
                    case "m10415":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第四网格'";
                        }
                        break;

                    case "m10501":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10502":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10503":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10504":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10505":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10506":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10507":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10508":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10509":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10510":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10511":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10512":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10513":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10514":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10515":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第五网格'";
                        }
                        break;
                    case "m10601":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10602":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10603":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10604":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10605":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10606":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10607":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10608":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10609":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10610":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10611":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10612":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10613":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10614":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;
                    case "m10615":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第六网格'";
                        }
                        break;

                    case "m10701":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10702":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10703":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10704":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10705":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10706":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10707":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10708":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10709":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10710":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10711":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10712":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10713":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10714":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10715":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第七网格'";
                        }
                        break;
                    case "m10801":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10802":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10803":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10804":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10805":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10806":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10807":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10808":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10809":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10810":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10811":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10812":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10813":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10814":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;
                    case "m10815":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第八网格'";
                        }
                        break;

                    case "m10901":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10902":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10903":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '1'  AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10904":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10905":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10906":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10907":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10908":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10909":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10910":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10911":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10912":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10913":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10914":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;
                    case "m10915":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '1' AND grid.`name`='草堂路第九网格'";
                        }
                        break;



                    case "m20101":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20102":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20103":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20104":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20105":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20106":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20107":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20108":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20109":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20110":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20111":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20112":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20113":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20114":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20115":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m20201":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20202":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20203":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20204":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20205":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20206":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20207":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20208":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20209":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20210":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20211":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20212":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20213":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20214":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20215":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第二网格'";
                        }
                        break;
                    case "m20301":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20302":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20303":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20304":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20305":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20306":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20307":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20308":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20309":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20310":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20311":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20312":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20313":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20314":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20315":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m20401":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20402":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20403":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20404":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20405":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20406":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20407":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20408":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20409":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20410":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20411":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20412":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20413":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20414":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m20415":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第四网格'";
                        }
                        break;

                    case "m20501":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20502":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20503":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20504":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20505":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20506":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20507":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20508":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20509":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20510":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20511":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20512":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20513":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20514":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20515":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m20601":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20602":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20603":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20604":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20605":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20606":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20607":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20608":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20609":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20610":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20611":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20612":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20613":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20614":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m20615":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第六网格'";
                        }
                        break;

                    case "m20701":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20702":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20703":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20704":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20705":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20706":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20707":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20708":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20709":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20710":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20711":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20712":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20713":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20714":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20715":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m20801":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20802":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20803":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20804":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20805":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20806":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20807":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20808":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20809":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20810":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20811":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20812":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20813":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20814":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m20815":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第八网格'";
                        }
                        break;

                    case "m20901":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20902":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20903":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20904":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20905":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20906":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20907":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20908":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20909":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20910":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20911":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20912":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20913":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20914":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m20915":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '2' AND grid.`name`='琴台路第九网格'";
                        }
                     break;


                    case "m30101":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30102":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30103":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m30104":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30105":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30106":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30107":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30108":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30109":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30110":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30111":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30112":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30113":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30114":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30115":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第一网格'";
                        }
                        break;
                    case "m30201":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30202":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30203":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30204":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30205":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30206":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30207":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30208":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30209":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30210":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30211":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30212":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30213":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30214":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30215":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第二网格'";
                        }
                        break;
                    case "m30301":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30302":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30303":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m30304":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30305":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30306":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30307":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30308":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30309":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30310":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30311":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30312":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30313":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30314":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30315":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第三网格'";
                        }
                        break;
                    case "m30401":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30402":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30403":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m30404":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30405":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30406":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30407":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30408":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30409":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30410":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30411":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30412":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30413":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30414":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;
                    case "m30415":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第四网格'";
                        }
                        break;

                    case "m30501":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30502":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30503":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m30504":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30505":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30506":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30507":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30508":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30509":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30510":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30511":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30512":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30513":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30514":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30515":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第五网格'";
                        }
                        break;
                    case "m30601":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30602":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30603":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m30604":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30605":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30606":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30607":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30608":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30609":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30610":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30611":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30612":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30613":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30614":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;
                    case "m30615":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第六网格'";
                        }
                        break;

                    case "m30701":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30702":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30703":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m30704":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30705":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30706":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30707":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30708":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30709":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30710":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30711":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30712":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30713":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30714":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30715":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第七网格'";
                        }
                        break;
                    case "m30801":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30802":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30803":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m30804":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30805":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30806":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30807":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30808":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30809":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30810":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30811":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30812":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30813":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30814":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;
                    case "m30815":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第八网格'";
                        }
                        break;

                    case "m30901":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30902":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30903":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m30904":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30905":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30906":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30907":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30908":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30909":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30910":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30911":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30912":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30913":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30914":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m30915":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '3' AND grid.`name`='芳邻路第九网格'";
                        }
                        break;
                    case "m40101":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40102":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40103":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第一网格'";
                        }
                        break;
                    case "m40104":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40105":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40106":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40107":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40108":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40109":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40110":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40111":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40112":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40113":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40114":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40115":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第一网格'";
                        }
                        break;
                    case "m40201":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40202":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40203":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40204":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40205":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40206":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40207":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40208":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40209":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40210":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40211":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40212":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40213":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40214":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40215":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第二网格'";
                        }
                        break;
                    case "m40301":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40302":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40303":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第三网格'";
                        }
                        break;
                    case "m40304":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40305":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40306":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40307":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40308":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40309":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40310":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40311":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40312":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40313":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40314":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40315":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第三网格'";
                        }
                        break;
                    case "m40401":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40402":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40403":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第四网格'";
                        }
                        break;
                    case "m40404":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40405":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40406":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40407":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40408":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40409":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40410":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40411":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40412":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40413":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40414":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;
                    case "m40415":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第四网格'";
                        }
                        break;

                    case "m40501":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40502":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40503":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第五网格'";
                        }
                        break;
                    case "m40504":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40505":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40506":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40507":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40508":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40509":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40510":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40511":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40512":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40513":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40514":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40515":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第五网格'";
                        }
                        break;
                    case "m40601":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40602":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40603":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第六网格'";
                        }
                        break;
                    case "m40604":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40605":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40606":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40607":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40608":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40609":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40610":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40611":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40612":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40613":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40614":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;
                    case "m40615":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第六网格'";
                        }
                        break;

                    case "m40701":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40702":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40703":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第七网格'";
                        }
                        break;
                    case "m40704":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40705":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40706":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40707":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40708":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40709":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40710":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40711":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40712":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40713":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40714":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40715":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第七网格'";
                        }
                        break;
                    case "m40801":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40802":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40803":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第八网格'";
                        }
                        break;
                    case "m40804":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40805":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40806":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40807":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40808":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40809":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40810":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40811":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40812":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40813":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40814":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;
                    case "m40815":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第八网格'";
                        }
                        break;

                    case "m40901":
                        {
                            sqlcmd += "WHERE population.educational = '党员'AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40902":
                        {
                            sqlcmd += "WHERE features.old IS NOT NULL AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40903":
                        {
                            sqlcmd += "WHERE features.old >= 1 AND features.old_alone >= 1 AND  district.id = '2'  AND grid.`name`='琴台路第九网格'";
                        }
                        break;
                    case "m40904":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40905":
                        {
                            sqlcmd += "WHERE features.handicapped >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40906":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40907":
                        {
                            sqlcmd += "WHERE features.foreigner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40908":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40909":
                        {
                            sqlcmd += "WHERE features.poor >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40910":
                        {
                            sqlcmd += "WHERE features.cleaner >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40911":
                        {
                            sqlcmd += "WHERE features.vip >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40912":
                        {
                            sqlcmd += "WHERE features.unjob >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40913":
                        {
                            sqlcmd += "WHERE features.dope >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40914":
                        {
                            sqlcmd += "WHERE features.correction >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;
                    case "m40915":
                        {
                            sqlcmd += "WHERE features.released >= 1 AND  district.id = '4' AND grid.`name`='送仙桥第九网格'";
                        }
                        break;


                    default:
                        break;
                }
                dgv.DataSource = db.GetDataSet(sqlcmd, "t").Tables["t"];
            }
        }

        private void sssq_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(sssq_cb, sswg_cb, "district", "grid");
        }

        private void sswg_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            commUse.district_gird_block(sswg_cb, ssyl_cb, "grid", "block");
        }
    }
}
