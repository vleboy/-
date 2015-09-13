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
