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
        public int Id = 0;
        public frmYeniUrun(int id)
        {
            InitializeComponent();
            Id = id;
            LoadData();
        }
        private void LoadData()
        {
            if (Id > 0)
            {
                var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Siparis.Properties.Settings.SiparislerDbConnectionString"].ConnectionString);
                var command = new SqlCommand("SELECT * FROM Urunler WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", this.Id);
                var dataAdapter = new SqlDataAdapter(command);
                DataTable resultTable = new DataTable();
                dataAdapter.Fill(resultTable);
                if (resultTable.Rows.Count > 0) { 
                    this.txtUrunAdi.Text = resultTable.Rows[0]["Ad"].ToString();
                    this.txtAciklama.Text = resultTable.Rows[0]["Aciklama"].ToString();
                    this.txtFiyat.Text = resultTable.Rows[0]["Fiyat"].ToString();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // ADO.NET ile veritabanına kaydetme işlemi
            var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Siparis.Properties.Settings.SiparislerDbConnectionString"].ConnectionString);
            SqlCommand command;
            if (Id > 0)
            {
                command = new SqlCommand("UPDATE Urunler SET Ad = @Ad, Aciklama = @Aciklama, Fiyat = @Fiyat WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", this.Id);
            } else
            {
                command = new SqlCommand("INSERT INTO Urunler (Ad, Aciklama, Fiyat) VALUES (@Ad, @Aciklama, @Fiyat)", connection);
            }
                

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
