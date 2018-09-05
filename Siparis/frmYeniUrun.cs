using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    public partial class frmYeniUrun : Form
    {
        public frmYeniUrun()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // ADO.NET ile veritabanına kaydetme işlemi
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Siparis.Properties.Settings.SiparislerDbConnectionString"].ConnectionString);
            var command = new SqlCommand("INSERT INTO Urunler (Ad, Aciklama, Fiyat) VALUES (@Ad, @Aciklama, @Fiyat)", connection);

            command.Parameters.AddWithValue("@Ad", this.txtUrunAdi.Text);
            command.Parameters.AddWithValue("@Aciklama", this.txtAciklama.Text);
            command.Parameters.AddWithValue("@Fiyat", this.txtFiyat.Text);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla kaydedildi.");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Ürün kaydedilirken bir hata oldu: " + ex.Message);
            } finally
            {
                connection.Close();
            }
        }
    }
}
