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
    public partial class addUser : Form
    {
        private readonly CommonUse commUse = new CommonUse();
        private readonly DataBase db = new DataBase();
        
        private int feature = 0;
        public addUser()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                feature += 1;
                cb_photo.Enabled = true;
                cb_hz.Enabled = true;
                cb_zk.Enabled = true;
                tb_mz.Enabled = true;
                tb_xjdz.Enabled = true;
                tb_yhzgx.Enabled = true;
                dtp_jlsj.Enabled = true;
                dtp_qfrq.Enabled = true;
            }
            else
            {
                feature -= 1;
                cb_photo.Enabled = false;
                cb_hz.Enabled = false;
                cb_zk.Enabled = false;
                tb_mz.Enabled = false;
                tb_xjdz.Enabled = false;
                tb_yhzgx.Enabled = false;
                dtp_jlsj.Enabled = false;
                dtp_qfrq.Enabled = false;
            }
        }

        private void cb_handicapped_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_handicapped.Checked)
            {
                feature += 1;
                cb_feature.Enabled = true;
                tb_hmz.Enabled = true;
                tb_cjz.Enabled = true;
                tb_dj.Enabled = true;
                tb_jkr.Enabled = true;
                tb_gx.Enabled = true;
               
            }
            else
            {
                feature -= 1;
                cb_feature.Enabled = false;
                tb_hmz.Enabled = false;
                tb_cjz.Enabled = false;
                tb_dj.Enabled = false;
                tb_jkr.Enabled = false;
                tb_gx.Enabled = false;
            }
        }

        private void cb_jwry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_jwry.Checked)
            {
                feature += 1;
                jwry_czjwr_cb.Enabled = true;
                jwry_f_cb.Enabled = true;
                jwry_gj_tb.Enabled = true;
                jwry_jdr_tb.Enabled = true;
                jwry_lksj_dtp.Enabled = true;
                jwry_lxrdh_tb.Enabled = true;
                jwry_lxr_tb.Enabled = true;
                jwry_qzlx_tb.Enabled = true;
                jwry_zjhm_tb.Enabled = true;
                jyry_qzyxq_dtp.Enabled = true;

            }
            else
            {
                feature -= 1;
                jwry_czjwr_cb.Enabled = false;
                jwry_f_cb.Enabled = false;
                jwry_gj_tb.Enabled = false;
                jwry_jdr_tb.Enabled = false;
                jwry_lksj_dtp.Enabled = false;
                jwry_lxrdh_tb.Enabled = false;
                jwry_lxr_tb.Enabled = false;
                jwry_qzlx_tb.Enabled = false;
                jwry_zjhm_tb.Enabled = false;
                jyry_qzyxq_dtp.Enabled = false;
            }
        }

        private void cb_dbry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_dbry.Checked)
            {
                feature += 1;
                dbry_id_tb.Enabled = true;

            }
            else
            {
                feature -= 1;
                dbry_id_tb.Enabled = false;
            }
        }

        private void cb_jzry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_jzry.Checked)
            {
                feature += 1;
                jzry_fzlx_tb.Enabled = true;
                jzry_jxjy_tb.Enabled = true;
                jzry_jzlb_tb.Enabled = true;
                jzry_jzqe_dtp.Enabled = true;
                jzry_jzqs.Enabled = true;
                jzry_jzqs_dtp.Enabled = true;
                jzry_ypxq.Enabled = true;
                jzry_zm_tb.Enabled = true;
                

            }
            else
            {
                feature -= 1;
                jzry_fzlx_tb.Enabled = false;
                jzry_jxjy_tb.Enabled = false;
                jzry_jzlb_tb.Enabled = false;
                jzry_jzqe_dtp.Enabled = false;
                jzry_jzqs.Enabled = false;
                jzry_jzqs_dtp.Enabled = false;
                jzry_ypxq.Enabled = false;
                jzry_zm_tb.Enabled = false;
            }
        }

        private void cb_xfsfry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xfsfry.Checked)
            {
                feature += 1;
                xmsfry_zxqz_dtp .Enabled = true;
                xmsfry_fxjyhdq_tb.Enabled = true;
                xmsfry_sfsj_dtp.Enabled = true;
                xmsfry_zm_tb.Enabled = true;
                xmsfry_zxqq_dtp.Enabled = true;
             

            }
            else
            {
                feature -= 1;
                xmsfry_zxqz_dtp.Enabled = false;
                xmsfry_fxjyhdq_tb.Enabled = false;
                xmsfry_sfsj_dtp.Enabled = false;
                xmsfry_zm_tb.Enabled = false;
                xmsfry_zxqq_dtp.Enabled = false;
            }
        }

        private void cb_xdry_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_xdry.Checked)
            {
                feature += 1;
                xdry_ccfxrq_dtp.Enabled = true;
                xdry_dplb_tb.Enabled = true;
                xdry_hjpcs_tb.Enabled = true;
                xdry_ryxz_tb.Enabled = true;
             }
            else
            {
                feature -= 1;
                xdry_ccfxrq_dtp.Enabled = false;
                xdry_dplb_tb.Enabled = false;
                xdry_hjpcs_tb.Enabled = false;
                xdry_ryxz_tb.Enabled = false;
            }
        }
      
        private void save_Click(object sender, EventArgs e)
        {
            string strcmd = string.Empty;
            if (feature != 0)
            {
                //先创建特性属性
            }
            strcmd = "INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`) VALUES('"+ ryinfo_card_id.Text + "', '"+ tb_names.Text + "', '"+ryinfo_age.Value.ToString()+"', '1', '1', '1', '1', '1', '1')";
            // INSERT INTO `population` (`card_id`, `name`, `age`, `address`, `gender`, `census_address`, `block`, `note`, `educational`) VALUES('1', '1', '1', '1', '1', '1', '1', '1', '1')
            feature = 0;
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            List<item> items = new List<item>();
             MySqlDataReader sdr;
             sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            cb_district.DataSource = items;
            items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            cb_grid.DataSource = items;
            items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            cb_block.DataSource = items;
            items.Clear();
            sdr.Close();
        }
    }
}
