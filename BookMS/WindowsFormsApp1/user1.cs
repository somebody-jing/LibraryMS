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
    public partial class user1 : Form
    {
        public user1()
        {
            InitializeComponent();
            label1.Text = $"{Data.UName}";
        }

        private void user1_Load(object sender, EventArgs e)
        {

        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 u = new user2();
            u.ShowDialog();
        }

        private void 当前借出图书和归还ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 u = new user3();
            u.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击相应选项查看、借阅和归还图书，更多问题可联系管理员");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
