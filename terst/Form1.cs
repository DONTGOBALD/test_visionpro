using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 新增检测程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            程序设置ToolStripMenuItem.DropDownItems.Add("程序1");
            Tool tool = new Tool();
            tool.ShowDialog();
        }
    }
}
