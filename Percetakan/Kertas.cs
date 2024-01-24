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
    public partial class Kertas : Form
    {
        public Kertas()
        {
            InitializeComponent();
            LoadDataKertas();
        }

        public void LoadDataKertas() {

            try
            {
                Koneksi.buka();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader rd;

                cmd.CommandText = "SELECT * FROM kertas";
                cmd.Connection = Koneksi.sqlConn;
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    int newIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newIndex].Cells[0].Value = rd["id_kertas"].ToString();
                    dataGridView1.Rows[newIndex].Cells[1].Value = rd["nama"].ToString();
                    dataGridView1.Rows[newIndex].Cells[2].Value = rd["harga"].ToString();
                    dataGridView1.Rows[newIndex].Cells[3].Value = "Edit";
                    dataGridView1.Rows[newIndex].Cells[4].Value = "Delete";
                }
                cmd.Dispose();
                rd.Close();
                Koneksi.tutup();
             
            }
            catch
            {
                MessageBox.Show("Terjadi error pada saat memuat data mobil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            KertasCreate frm = new KertasCreate();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "Insert data kertas";
            if(frm.ShowDialog() == DialogResult.OK) 
            { LoadDataKertas(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //klik edit
            { 
            KertasCreate frm = new KertasCreate();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "Insert data kertas";
            frm.id_kertas = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            frm.txtNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Tambahkan baris baru setelah diedit
                    int newIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newIndex].Cells[0].Value = frm.id_kertas.ToString();
                    dataGridView1.Rows[newIndex].Cells[1].Value = frm.txtNama.Text;
                    dataGridView1.Rows[newIndex].Cells[2].Value = frm.txtHarga.Text;
                    dataGridView1.Rows[newIndex].Cells[3].Value = "Edit";
                    dataGridView1.Rows[newIndex].Cells[4].Value = "Delete";
                }
        }
            if (e.ColumnIndex == 4) //klik delete
            {
                //konfirmasi dulu sebelumm hapus

                if (MessageBox.Show("Apakah yakin menghapus kertas ini?", "Konfirmasi",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    string id_kertas = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //koneksi ke database 
                    Koneksi.buka();

                    //buat command sql delete
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Koneksi.sqlConn;
                    cmd.CommandText = "DELETE FROM kertas WHERE id_kertas = @pID";
                    cmd.Parameters.AddWithValue("pID", dataGridView1.Rows[e.RowIndex].Cells[0].Value);

                    //eksekusi command
                    cmd.ExecuteNonQuery();
                    Koneksi.tutup();
                    cmd.Dispose();
                    
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                catch
                {
                    MessageBox.Show("Terjadi error pada saat menghapus data ini", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
