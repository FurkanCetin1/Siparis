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
        public frmUrunler urunlerFormu;
        private void tümÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (urunlerFormu == null || urunlerFormu.IsDisposed)
            {
                urunlerFormu = new frmUrunler();
                urunlerFormu.MdiParent = this;
            }
            urunlerFormu.Show();
        }
        public frmYeniUrun yeniUrunFormu;
        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yeniUrunFormu == null || yeniUrunFormu.IsDisposed)
            {
                yeniUrunFormu = new frmYeniUrun();
                yeniUrunFormu.MdiParent = this;
            }
            yeniUrunFormu.Show();
        }
    }
}
