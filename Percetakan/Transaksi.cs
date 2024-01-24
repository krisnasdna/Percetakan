using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percetakan
{
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
            LoadDataKategori();
            LoadDataKertas();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tanggal();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        void Tanggal()
        {
            tbTanggal.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public void LoadDataKategori()
        {
            
            Koneksi.buka();

           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;
            cmd.CommandText = "SELECT * FROM kategori ";


            
            SqlDataReader rd = cmd.ExecuteReader();

            
            while (rd.Read())
            {
                string vID = rd["id_kategori"].ToString();
                string vNamaKat = rd["nama"].ToString();
                string vHargaKat = rd["harga_kat"].ToString();
                
                cbKategori.Items.Add(vID + "-" + vNamaKat + "-" + vHargaKat );
            }
            rd.Close();
            Koneksi.tutup();
        }
        public void LoadDataKertas()
        {
            Koneksi.buka();

           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;
            cmd.CommandText = "SELECT * FROM kertas ";


            
            SqlDataReader rd = cmd.ExecuteReader();

            
            while (rd.Read())
            {
                string vID = rd["id_kertas"].ToString();
                string vNamaKer = rd["nama"].ToString();
                string vHargaKer = rd["harga"].ToString();

                cbKertas.Items.Add(vID + "-" + vNamaKer + "-" + vHargaKer);
            }
            rd.Close();
            Koneksi.tutup();
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vSplitKat = cbKategori.Text.Split('-');
            string hargaKat = vSplitKat[2];
            tbKategori.Text = hargaKat;
            
        }

        private void cbKertas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] vSplitKer = cbKertas.Text.Split('-');
            string hargaKer = vSplitKer[2];
             tbKertas.Text = hargaKer;
            numericJumlah.Value = 1;
            decimal TotalHarga = numericJumlah.Value * (int.Parse(tbKategori.Text) + int.Parse(tbKertas.Text));
            tbHarga.Text = TotalHarga.ToString();
        }

        private void numericJumlah_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TotalHargaJum = numericJumlah.Value * int.Parse(tbHarga.Text);
                tbHarga.Text = TotalHargaJum.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koneksi.buka();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;
            cmd.CommandText = "INSERT INTO transaksi (id_kategori, tgl_transaksi, jumlah, total_harga, id_kertas) VALUES (@pIdKategori, @pTglTransaksi, @pJumlah, @pTotalHarga, @pIdKertas)";
            string[] vSplitKat = cbKategori.Text.Split('-');
            string id_kategori = vSplitKat[0];

            string[] vSplitKer = cbKertas.Text.Split('-');
            string id_kertas = vSplitKer[0];

            cmd.Parameters.AddWithValue("pIdKategori", id_kategori);
            cmd.Parameters.AddWithValue("pTglTransaksi", tbTanggal.Text);
            cmd.Parameters.AddWithValue("pJumlah", numericJumlah.Value);
            cmd.Parameters.AddWithValue("pTotalHarga", tbHarga.Text);
            cmd.Parameters.AddWithValue("pIdKertas", id_kertas);
          
            cmd.ExecuteNonQuery(); 

           
            Koneksi.tutup();
            MessageBox.Show("Data transaksi berhasil disimpan");

            tbHarga.Text = "";
            cbKategori.Items.Clear();
            cbKategori.Text = "";
            tbKategori.Text = "";
            cbKertas.Items.Clear();
            cbKertas.Text = "";
            tbKertas.Text = "";
            tbTanggal.Text = "";
            numericJumlah.Value = 0;
            
        }
    }
}
