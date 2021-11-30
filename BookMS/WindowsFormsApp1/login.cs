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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了登录");
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }
		public void Login()
		{
			MessageBox.Show("登录中");
			//用户
			if (radioButtonUser.Checked == true)
			{
				Dao dao = new Dao();
				string sql = $"select* from t_user where id='{textBox1.Text}'and psw='{textBox2.Text}'";
				//MessageBox.Show(sql);
				IDataReader dc = dao.read(sql);
				if (dc.Read())

				//MessageBox.Show(dc[0].ToString()+dc["name"].Tostring());
				{
					Data.UID = dc["id"].ToString();
					Data.UName = dc["name"].ToString();

					MessageBox.Show("登录成功");
					user1 user = new user1();
					this.Hide();
					user.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("登录失败");
				}
				dao.DaoClose();
			}
			//管理员
			if (radioButtonAdmin.Checked == true)
			{
				Dao dao = new Dao();
				string sql = $"select* from t_admin where id='{textBox1.Text}'and psw='{textBox2.Text}'";
				//MessageBox.show(sql);
				IDataReader dc = dao.read(sql);
				if (dc.Read())

				//MessageBox.Show(dc[0].ToString()+dc["name"].Tostring());
				{
					MessageBox.Show("登录成功");
					admin1 a = new admin1();
					this.Hide();
					a.ShowDialog();
					this.Show();
				}
				else
				{
					MessageBox.Show("登录失败");
				}
				dao.DaoClose();
			}
			MessageBox.Show("请选则单选框");
		}

	}
}
