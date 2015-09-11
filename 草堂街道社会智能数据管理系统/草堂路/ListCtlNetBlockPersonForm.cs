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
        string sqlcmd_handicapped_mental = "SELECT COUNT(a.id) FROM handicapped AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.handicapped_type = '精神'";
        string sqlcmd_foreigner = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.foreigner IS NOT NULL";
        string sqlcmd_old = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.old IS NOT NULL";
        string sqlcmd_oldalone = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.old_alone IS NOT NULL";
        string sqlcmd_poor = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.poor IS NOT NULL";
        string sqlcmd_correction = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.correction IS NOT NULL";
        string sqlcmd_released = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.released IS NOT NULL";
        string sqlcmd_dope = "SELECT COUNT(a.id) FROM features AS a, population AS b WHERE b.block = 1 AND a.id = b.features AND a.dope IS NOT NULL";
        string sqlcmd_gdv_preson = "SELECT * ,case gender when true then '男' when false then '女' end as sex FROM  population WHERE block = 1 AND features IS NULL";
        string sqlcmd_gdv_resident = "SELECT population.`name`,population.age,population.card_id,population.address,population.gender,population.census_address,population.note,population.educational,resident.resident_addresss,resident.tenants,resident.photo,resident.registration_date,resident.now_date,resident.ethnic FROM features INNER JOIN population ON population.features = features.id INNER JOIN resident ON features.resident = resident.id";
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
           // dataGridView3.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_preson, cmdnum), "t").Tables["t"];
           // dataGridView4.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_resident, cmdnum), "t").Tables["t"];
          //  dataGridView5.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_preson, cmdnum), "t").Tables["t"];
          //  dataGridView6.DataSource = db.GetDataSet(returnSqlCmd(sqlcmd_gdv_resident, cmdnum), "t").Tables["t"];
        }
        private void ListCtlNetBlockPersonForm_Load(object sender, EventArgs e)
        {
            

            switch (resident)
            {
                case 1://草堂
                    {
                        laresident.Text = "草堂路";
                        switch (grid)
                        {
                            case 1:
                                {
                                    lagrid.Text = "第一网格";
                                    switch (block)
                                    {
                                        case 1:
                                            {
                                                lablock.Text = "青华路25号院落";
                                                viewgdv("1");
                                            
                                                break;
                                            }
                                        case 2:
                                            {

                                            }
                                            break;
                                        case 3:
                                            {

                                            }
                                            break;
                                        case 4:
                                            {

                                            }
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            break;
                            case 2:
                                {

                                }
                                break;
                            case 3:
                                {

                                }
                                break;
                            case 4:
                                {

                                }
                                break;
                            case 5:
                                {

                                }
                                break;
                            case 6:
                                {

                                }
                                break;
                            case 7:
                                {

                                }
                                break;
                            case 8:
                                {

                                }
                                break;
                            case 9:
                                {

                                }
                                break;
                            case 10:
                                {

                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {

                    }
                    break;
                case 4:
                    {

                    }
                break;
                default:
                    break;
            }
        }
    }
}
