using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using 草堂街道社会智能数据管理系统.dataClass;
using 草堂街道社会智能数据管理系统.ComClass;
using MySql.Data.MySqlClient;

namespace 草堂街道社会智能数据管理系统
{
    public partial class Login : Form
    {
        private readonly DataBase db = new DataBase();
        private MySqlDataReader sdr;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errInfo.Clear();

            if (String.IsNullOrEmpty(tbUser.Text.Trim()))
            {
                try
                {
                    errInfo.SetError(tbUser, "用户名不能为空！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

                finally { }
            }

            if (String.IsNullOrEmpty(tbPassword.Text.Trim()))
            {
                try
                {
                    errInfo.SetError(tbPassword, "密码不能为空！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "软件提示");
                    throw ex;
                }

                finally { }

            }

            string strSql = "select * from user where username = '" + tbUser.Text.Trim() +
                            "' and password = '" + tbPassword.Text.Trim() + "'"; 

            try
            {
                sdr = db.GetDataReader(strSql);
                sdr.Read();
                if (sdr.HasRows)
                {
                    Main AppForm = new Main();
                    Hide();
                    PropetyClass.User = sdr["username"].ToString();

                    PropetyClass.PassWord = sdr["password"].ToString();

                    AppForm.Show();
                }
                else
                {
                    MessageBox.Show("用户编码或用户密码不正确！", "软件提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "软件提示");
                throw;
            }
            finally
            {
                sdr.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        //登录用户文本框敲回车键
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbUser.Focus();
            }
        }

        //登录密码文本框敲回车键
       
        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click( sender,e);
            }
        }
    }
}
