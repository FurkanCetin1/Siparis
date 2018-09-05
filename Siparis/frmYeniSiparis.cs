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
    public partial class frmYeniSiparis : Form
    {
        public frmYeniSiparis()
        {
            InitializeComponent();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Siparis.Properties.Settings.SiparislerDbConnectionString"].ConnectionString);

            var command = new SqlCommand("INSERT INTO Siparisler (SiparisVeren, SiparisDetayi, Tarih) VALUES (@SiparisVeren, @SiparisDetayi, @Tarih)", connection);
            command.Parameters.AddWithValue("@SiparisVeren", this.txtSiparisVeren.Text);
            command.Parameters.AddWithValue("@SiparisDetayi", this.txtSiparisDetayi.Text);
            command.Parameters.AddWithValue("@Tarih", this.dtpTarih.Value);

            try {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Kaydetme işlemi başarıyla gerçekleşti.");
            } catch(Exception ex)
            {
                MessageBox.Show("İşlem sırasında bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
