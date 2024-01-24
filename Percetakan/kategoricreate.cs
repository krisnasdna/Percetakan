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
    public partial class kategoricreate : Form
    {
        public int id_kategori = 0;
        public kategoricreate()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //koneksi ke database
            Koneksi.buka();

            //membuat perintah SQL 
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;

            if (id_kategori == 0)
            {
                cmd.CommandText = "INSERT INTO kategori (nama, harga_kat)"
                            + "VALUES (@pNama, @pHarga)";
            }
            else if (id_kategori > 0)
            {
                cmd.CommandText = "UPDATE kategori SET "
                          + " nama = @pNama, harga_kat = @pHarga "
                          + " WHERE id_kategori = @pID ";
                cmd.Parameters.AddWithValue("pID", id_kategori);
            }

            cmd.Parameters.AddWithValue("pNama", txtnama.Text);
            cmd.Parameters.AddWithValue("pHarga", txtharga.Text);
            



            //eksekusi command tsb
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Terjadi error pada saat menyimpan data ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            Koneksi.tutup();
            cmd.Dispose();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }
    }
}
