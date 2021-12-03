using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class admin11 : Form
    {
        public admin11()
        {
            InitializeComponent();
        }

        private void admin11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                Dao dao = new Dao();
                string sql1 = $"select id from t_user where id='{textBox1.Text}'";
                int n1 = dao.Execute(sql1);
                if (n1 == -1)
                {
                    MessageBox.Show("该用户已存在");
                }
                else
                {
                    string sql = $"insert into t_user values('{textBox1.Text}','{textBox3.Text}','{textBox2.Text}','{textBox4.Text}')";
                    int n = dao.Execute(sql);
                    if (n > 0)
                    {
                        MessageBox.Show("注册成功");

                    }
                    else
                    {
                        MessageBox.Show("注册失败");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            else
            {
                MessageBox.Show("用户信息不能为空");
            }
        }
    }
}
