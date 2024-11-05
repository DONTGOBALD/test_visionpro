using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;

namespace terst
{
    public partial class Tool : Form
    {
        public Tool()
        {
            InitializeComponent();
        }
        private string path = @"D:\vs_Test\新建文件夹\213.vpp";
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                CogSerializer.SaveObjectToFile(this.cogToolBlockEditV21.Subject, path);
                MessageBox.Show("程序保存成功");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cogToolBlockEditV21_Load(object sender, EventArgs e)
        {

        }
    }
}
