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
    public partial class KertasCreate : Form
    {
        public int id_kertas = 0;
        public KertasCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Koneksi.buka();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;

            if (id_kertas == 0)
            {
                cmd.CommandText = "Insert into kertas (nama,harga) values (@pNama,@pHarga)";

            }
            else if(id_kertas > 0){
                cmd.CommandText = "Update kertas SET nama = @pNama, harga = @pHarga Where id_kertas = @pIdKertas";

                cmd.Parameters.AddWithValue("pIdKertas", id_kertas);
            }
            cmd.Parameters.AddWithValue("@pNama", txtNama.Text);
            cmd.Parameters.AddWithValue("@pHarga", txtHarga.Text);

            try { cmd.ExecuteNonQuery(); } catch { MessageBox.Show("Terjadi error pada saat menyimpan data ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            Koneksi.tutup();
            cmd.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
