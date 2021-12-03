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
    public partial class user2 : Form
    {
        public user2()
        {
            InitializeComponent();
            Table();
        }

        private void user2_Load(object sender, EventArgs e)
        {

        }
        public void Table()
        {
            dataGridView1.Rows.Clear();//清空数据
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取书号
            int number = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());//库存
            if (number < 1)
            {
                MessageBox.Show("库存不足，请联系管理员购入！");
            }
            else
            {
                string sql = $"insert into t_lend ([uid],bid,[datetime]) values('{Data.UID}','{id}',getdate());update t_book set number=number-1 where id='{id}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)//执行两条sql，>1才为都执行成功
                {
                    MessageBox.Show($"用户: {Data.UName}借出了图书{id}!");
                    Table();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void TableID()
        {
            dataGridView1.Rows.Clear();//清空数据
            Dao dao = new Dao();
            string sql = $"select * from t_book where id='{textBox1.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void TableName()
        {
            dataGridView1.Rows.Clear();//清空数据
            Dao dao = new Dao();
            string sql = $"select * from t_book where name like'%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            TableID();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            TableName();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("刷新");
            Tabel();
            textBox1.Text = "";
            textBox2.Text = "";
        }
        public void Tabel()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())//图书的添加
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());

            }
            dc.Close();
            dao.DaoClose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
