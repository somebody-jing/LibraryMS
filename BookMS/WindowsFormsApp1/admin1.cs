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
    public partial class admin1 : Form
    {
        public admin1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             admin2 a = new admin2();
            a.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎管理员");
        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 用户注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin11 a = new admin11();
            a.ShowDialog();
        }

        private void 查看用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin12 a = new admin12();
            a.ShowDialog();
        }
    }
}
