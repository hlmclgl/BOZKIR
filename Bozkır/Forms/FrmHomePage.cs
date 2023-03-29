using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bozkır.Forms
{
    public partial class FrmHomePage: Form
    {
        public FrmHomePage()
        {
            InitializeComponent();
        }

        private void FrmHomePage_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Araç Hızı"].Points.AddPoint(0, 0);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(1, 1);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(2, 4);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(3, 1);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(4, 2);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(5, 5);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(6, 3);
            chartControl1.Series["Araç Hızı"].Points.AddPoint(7, 7);
        }

        
    }
}
