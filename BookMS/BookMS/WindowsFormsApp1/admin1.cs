﻿using System;
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
    }
}
