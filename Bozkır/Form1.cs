using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bozkır
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mapControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHomePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

      
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void homePage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmHomePage frm = new Forms.FrmHomePage();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
