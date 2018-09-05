using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public frmSiparisler siparislerFormu;
        private void tümSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparislerFormu == null || siparislerFormu.IsDisposed)
            {
                siparislerFormu = new frmSiparisler();
                siparislerFormu.MdiParent = this;
            }
            siparislerFormu.Show();
        }
        public frmYeniSiparis yeniSiparisFormu;
        private void yeniSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yeniSiparisFormu == null || yeniSiparisFormu.IsDisposed)
            {
                yeniSiparisFormu = new frmYeniSiparis();
                yeniSiparisFormu.MdiParent = this;
            }
            yeniSiparisFormu.Show();
        }
    }
}
