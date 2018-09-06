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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'siparislerDbDataSet.Urunler' table. You can move, or remove it, as needed.
            this.urunlerTableAdapter.Fill(this.siparislerDbDataSet.Urunler);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var anaForm = this.MdiParent as Form1;
            var yeniUrunFormu = anaForm.yeniUrunFormu;
            if (yeniUrunFormu == null || yeniUrunFormu.IsDisposed)
            {
                int id = Convert.ToInt32(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                yeniUrunFormu = new frmYeniUrun(id);
                yeniUrunFormu.MdiParent = anaForm;
            }
            yeniUrunFormu.Show();
        }
    }
}
