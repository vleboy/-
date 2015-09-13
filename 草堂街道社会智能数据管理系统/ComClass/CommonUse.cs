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
                case "111":

                    ListCtlNetBlockPersonForm Ctl11 = new ListCtlNetBlockPersonForm();
                    Ctl11.MdiParent = form;
                    Ctl11.StartPosition = FormStartPosition.CenterScreen;
                    Ctl11.Tag = la.Tag.ToString();
                    Ctl11.WindowState = FormWindowState.Maximized;
                    Ctl11.main = form;
                    Ctl11.resident = 1;
                    Ctl11.block = 1;
                    Ctl11.grid = 1;
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
                case "m1"://党员
                case "m2"://党员
                case "m3"://党员
                case "m4"://党员
                case "m5"://党员
                case "m6"://党员
                case "m7"://党员
                case "m8"://党员
                case "m9"://党员
                case "m10"://党员
                case "m11"://党员
                case "m12"://党员
                case "m13"://党员
                case "m14"://党员
                case "m15"://党员
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
