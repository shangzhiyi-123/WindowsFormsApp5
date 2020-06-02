using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        DB dB = new DB();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;

            //循环验证文本控件不为空
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty((c as TextBox).Text))
                    {
                        MessageBox.Show("填写内容均不能为空");
                        return;
                    }
                }
            }
            string sql = string.Format("select LoginPwd from Admin where LoginId='{0}'", name);
            SqlDataReader dr = dB.GetSqlDataReader(sql);
            if (dr.Read())
            {
                string loginPwd = (string)dr["LoginPwd"];
                if (loginPwd == pwd)
                {
                    MessageBox.Show("登陆成功");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("密码错误");

                }
            }
            else
            {
                MessageBox.Show("账号错误");

            }
        }

        /// TextBox控件清除方法
        /// </summary>
        /// <param name="ctrlTop"></param>
        private void ClearText(Control ctrlTop)
        {
            if (ctrlTop.GetType() == typeof(TextBox))
                ctrlTop.Text = "";
            else
            {
                foreach (Control ctrl in ctrlTop.Controls)
                {
                    ClearText(ctrl); //循环调用
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearText(this);
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
        }
    }
}
