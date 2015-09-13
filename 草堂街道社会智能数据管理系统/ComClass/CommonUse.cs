using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.dataClass;
using 草堂街道社会智能数据管理系统.草堂路;

namespace 草堂街道社会智能数据管理系统.ComClass
{
    /// <summary>
    ///   公共的通用类，提供一些通用的方法
    /// </summary>
    /// 

    class CommonUse
    {
        private readonly DataBase db = new DataBase();

        /// <summary>
        ///   TreeView控件绑定到数据源
        /// </summary>
        /// <param name="tv"> TreeView控件 </param>
        /// <param name="imgList"> ImageList控件 </param>
        /// <param name="rootName"> 根节点的文本属性值 </param>
        /// <param name="strTable"> 要绑定的数据表 </param>
        /// <param name="strCode"> 数据表的代码列 </param>
        /// <param name="strName"> 数据表的名称列 </param>
        /// 
        public void BuildTree(TreeView tv, ImageList imgList, string rootName, string strTable, string strCode,
                              string strName)
        {
            string strSql = null;
            DataSet ds = null;
            DataTable dt = null;
            TreeNode rootNode = null;
            TreeNode childNode = null;

            strSql = "select " + strCode + " , " + strName + " from " + strTable;
            tv.Nodes.Clear();
            tv.ImageList = imgList;
            //创建根节点
            rootNode = new TreeNode();
            rootNode.Tag = null;
            rootNode.Text = rootName;
            rootNode.ImageIndex = 1;
            rootNode.SelectedImageIndex = 0;

            try
            {
               // ds = db.GetDataSet(strSql, strTable);
                dt = ds.Tables[strTable];

                foreach (DataRow row in dt.Rows)
                {
                    //创建子节点
                    childNode = new TreeNode();
                    childNode.Tag = row[strCode]; 
                    childNode.Text = row[strName].ToString();
                    childNode.ImageIndex = 1;
                    childNode.SelectedImageIndex = 0;
                    rootNode.Nodes.Add(childNode);
                }

                tv.Nodes.Add(rootNode);
                tv.ExpandAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "软件提示");
                throw e;
            } 
        }


        public void ShowForm(string ob, Form form)
        {
            switch (ob)
            {
                case "list"://列表

                    ListMainForm ListMain = new ListMainForm();
                    ListMain.MdiParent = form;
                    ListMain.StartPosition = FormStartPosition.CenterScreen;
                    ListMain.Tag = ob;
                    ListMain.WindowState = FormWindowState.Maximized;
                    ListMain.main = form;
                    ListMain.Show();
                    break;
                case "map"://列表

                  
                    break;
                case "manager"://列表

                    ppmanager appmanager = new ppmanager();
                    appmanager.MdiParent = form;
                    appmanager.StartPosition = FormStartPosition.CenterScreen;
                    appmanager.Tag = ob;
                    appmanager.WindowState = FormWindowState.Maximized;
                    appmanager.main = form;
                    appmanager.Show();
                    break;
                case "add"://列表

                    addUser add = new addUser();
                    add.MdiParent = form;
                    add.StartPosition = FormStartPosition.CenterScreen;
                    add.Tag = ob;
                    add.WindowState = FormWindowState.Normal;
                    add.main = form;
                    add.Show();
                    break;
            }
        }

        public void ShowForm(Label la, Form form)
        {
            switch (la.Tag.ToString())
            {
                case "0"://列表

                    ListCtlNetFrom1 sxq = new ListCtlNetFrom1();
                    sxq.MdiParent = form;
                    sxq.StartPosition = FormStartPosition.CenterScreen;
                    sxq.Tag = la.Tag.ToString();
                    sxq.WindowState = FormWindowState.Maximized;
                    sxq.main = form;
                    sxq.Show();
                    break;
                
                case "1"://草堂路社区

                    ListCtlFrom Ctl = new ListCtlFrom();
                    Ctl.MdiParent = form;
                    Ctl.StartPosition = FormStartPosition.CenterScreen;
                    Ctl.Tag = la.Tag.ToString();
                    Ctl.WindowState = FormWindowState.Maximized;
                    Ctl.main = form;
                    Ctl.district = "1";
                    Ctl.Show();
                    break;
                case "11"://草堂路社区网格1

                    ListCtlNetForm1 Ctl1 = new ListCtlNetForm1();
                    Ctl1.MdiParent = form;
                    Ctl1.StartPosition = FormStartPosition.CenterScreen;
                    Ctl1.Tag = la.Tag.ToString();
                    Ctl1.WindowState = FormWindowState.Maximized;
                    Ctl1.main = form;
                    Ctl1.Show();
                    break;
                case "12"://草堂路社区网格2

                    ListCtlNetForm2 Ctl2 = new ListCtlNetForm2();
                    Ctl2.MdiParent = form;
                    Ctl2.StartPosition = FormStartPosition.CenterScreen;
                    Ctl2.Tag = la.Tag.ToString();
                    Ctl2.WindowState = FormWindowState.Maximized;
                    Ctl2.main = form;
                    Ctl2.Show();
                    break;
                case "13"://草堂路社区网格3

                    ListCtlNetForm3 Ctl3 = new ListCtlNetForm3();
                    Ctl3.MdiParent = form;
                    Ctl3.StartPosition = FormStartPosition.CenterScreen;
                    Ctl3.Tag = la.Tag.ToString();
                    Ctl3.WindowState = FormWindowState.Maximized;
                    Ctl3.main = form;
                    Ctl3.Show();
                    break;
                case "14"://草堂路社区网格4

                    ListCtlNetForm4 Ctl4 = new ListCtlNetForm4();
                    Ctl4.MdiParent = form;
                    Ctl4.StartPosition = FormStartPosition.CenterScreen;
                    Ctl4.Tag = la.Tag.ToString();
                    Ctl4.WindowState = FormWindowState.Maximized;
                    Ctl4.main = form;
                    Ctl4.Show();
                    break;
                case "15"://草堂路社区网格5

                    ListCtlNetForm5 Ctl5 = new ListCtlNetForm5();
                    Ctl5.MdiParent = form;
                    Ctl5.StartPosition = FormStartPosition.CenterScreen;
                    Ctl5.Tag = la.Tag.ToString();
                    Ctl5.WindowState = FormWindowState.Maximized;
                    Ctl5.main = form;
                    Ctl5.Show();
                    break;
                case "16"://草堂路社区网格6

                    ListCtlNetForm6 Ctl6 = new ListCtlNetForm6();
                    Ctl6.MdiParent = form;
                    Ctl6.StartPosition = FormStartPosition.CenterScreen;
                    Ctl6.Tag = la.Tag.ToString();
                    Ctl6.WindowState = FormWindowState.Maximized;
                    Ctl6.main = form;
                    Ctl6.Show();
                    break;
                case "17"://草堂路社区网格7

                    ListCtlNetForm7 Ctl7 = new ListCtlNetForm7();
                    Ctl7.MdiParent = form;
                    Ctl7.StartPosition = FormStartPosition.CenterScreen;
                    Ctl7.Tag = la.Tag.ToString();
                    Ctl7.WindowState = FormWindowState.Maximized;
                    Ctl7.main = form;
                    Ctl7.Show();
                    break;
                case "18"://草堂路社区网格8

                    ListCtlNetForm8 Ctl8 = new ListCtlNetForm8();
                    Ctl8.MdiParent = form;
                    Ctl8.StartPosition = FormStartPosition.CenterScreen;
                    Ctl8.Tag = la.Tag.ToString();
                    Ctl8.WindowState = FormWindowState.Maximized;
                    Ctl8.main = form;
                    Ctl8.Show();
                    break;
                case "19"://草堂路社区网格9

                    ListCtlNetForm9 Ctl9 = new ListCtlNetForm9();
                    Ctl9.MdiParent = form;
                    Ctl9.StartPosition = FormStartPosition.CenterScreen;
                    Ctl9.Tag = la.Tag.ToString();
                    Ctl9.WindowState = FormWindowState.Maximized;
                    Ctl9.main = form;
                    Ctl9.Show();
                    break;
                case "111":
                case "112":
                case "113":
                case "114":
                case "121":
                case "131":
                case "132":
                case "133":
                case "134":
                case "135":
                case "136":
                case "141":
                case "142":
                case "143":
                case "151":
                case "152":
                case "153":
                case "161":
                case "171":
                case "172":
                case "181":
                case "182":
                case "191":
                case "192":
                case "193":
                case "211":
                case "212":
                case "213":
                case "214":
                case "215":
                    ListCtlNetBlockPersonForm Ctl11 = new ListCtlNetBlockPersonForm();
                    Ctl11.MdiParent = form;
                    Ctl11.StartPosition = FormStartPosition.CenterScreen;
                    Ctl11.Tag = la.Tag.ToString();
                    Ctl11.WindowState = FormWindowState.Maximized;
                    Ctl11.main = form;
                    Ctl11.resident = Convert.ToInt16(la.Tag.ToString()[0].ToString());
                    Ctl11.grid = Convert.ToInt16(la.Tag.ToString()[1].ToString()); 
                    Ctl11.block = Convert.ToInt16(la.Tag.ToString()[2].ToString()); 
                    Ctl11.Show();
                    break;
       
             
               

                
                case "2"://列表

                    ListQtlFrom Qtl = new ListQtlFrom();
                    Qtl.MdiParent = form;
                    Qtl.StartPosition = FormStartPosition.CenterScreen;
                    Qtl.Tag = la.Tag.ToString();
                    Qtl.WindowState = FormWindowState.Maximized;
                    Qtl.Show();
                    break;

                case "3"://列表

                    ListFllFrom Fll = new ListFllFrom();
                    Fll.MdiParent = form;
                    Fll.StartPosition = FormStartPosition.CenterScreen;
                    Fll.Tag = la.Tag.ToString();
                    Fll.WindowState = FormWindowState.Maximized;
                    Fll.Show();
                    break;
                case "m1": 
                case "m2": 
                case "m3": 
                case "m4": 
                case "m5": 
                case "m6": 
                case "m7": 
                case "m8": 
                case "m9": 
                case "m10": 
                case "m11": 
                case "m12": 
                case "m13": 
                case "m14": 
                case "m15":
                case "m101":
                case "m102":
                case "m103":
                case "m104":
                case "m105":
                case "m106":
                case "m107":
                case "m108":
                case "m109":
                case "m110":
                case "m111":
                case "m112":
                case "m113":
                case "m114":
                case "m115":
                    ppmanager m1 = new ppmanager();

                    m1.MdiParent = form;
                    m1.StartPosition = FormStartPosition.CenterScreen;
                    m1.Tag = la.Tag.ToString();
                    m1.WindowState = FormWindowState.Maximized;
                    m1.Show();
                break;


            }
        }

        public void district_gird_block(ComboBox cb1,ComboBox cb2,string from1,string from2)
        {

            //string index = null;
            //    List<item> items = new List<item>();
            //    MySqlDataReader sdr;
            //    item it = (item)cb_grid.SelectedItem;
            //    index = it.Value;
            //    sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = " + index);
            //    while (sdr.Read())
            //    {
            //        item its = new item(sdr[0].ToString(), sdr[1].ToString());
            //        items.Add(its);
            //    }
            //     sdr.Close();
            //     cb_block.DataSource = items;

            string sqlcmd = "SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = ";
            sqlcmd = sqlcmd.Replace("grid", from2);
            sqlcmd =  sqlcmd.Replace("district", from1);

            string index = null;
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            item it = (item)cb1.SelectedItem;
            index = it.Value;

            // sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = " + index);
            sdr = db.GetDataReader(sqlcmd + index);
            while (sdr.Read())
            {
                item its = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(its);
            }
            sdr.Close();
            cb2.DataSource = items;
        }

        public void load_district(ComboBox district,ComboBox grid ,ComboBox block)
        {
            List<item> items = new List<item>();
            MySqlDataReader sdr;
            sdr = db.GetDataReader("SELECT district.`name`,district.`id` FROM district");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            district.DataSource = items;
            //   items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	grid.`name`,grid.id FROM district INNER JOIN grid ON grid.district = district.id WHERE district.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            grid.DataSource = items;
            //  items.Clear();
            sdr.Close();
            sdr = db.GetDataReader("SELECT 	block.`name`,block.id FROM grid INNER JOIN block ON block.grid = grid.id WHERE grid.id = 1");
            while (sdr.Read())
            {
                item it = new item(sdr[0].ToString(), sdr[1].ToString());
                items.Add(it);
            }
            block.DataSource = items;
            //  items.Clear();
            sdr.Close();
        }
    }
}
