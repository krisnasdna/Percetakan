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
    public partial class Kategori : Form
    {
        public int id_kategori = 0;
        public Kategori()
        {
            InitializeComponent();
            LoadDataKategori();
        }
        public void LoadDataKategori()
        {
            try
            {
                Koneksi.buka();

                SqlCommand cmd = new SqlCommand();
                SqlDataReader rd;

                cmd.CommandText = "SELECT * FROM kategori Order by id_kategori";
                cmd.Connection = Koneksi.sqlConn;

                rd = cmd.ExecuteReader();



                while (rd.Read())
                {
                    int newIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newIndex].Cells[0].Value = rd["id_kategori"].ToString();
                    dataGridView1.Rows[newIndex].Cells[1].Value = rd["nama"].ToString();
                    dataGridView1.Rows[newIndex].Cells[2].Value = rd["harga_kat"].ToString();
                    dataGridView1.Rows[newIndex].Cells[3].Value = "Edit";
                    dataGridView1.Rows[newIndex].Cells[4].Value = "Delete";

                }
                cmd.Dispose();
                rd.Close();
                Koneksi.tutup();
            }
            catch
            {
                MessageBox.Show("Terjadi error pada saat memuat data kategori", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            kategoricreate frm = new kategoricreate();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Text = "Insert Data Kategori Baru";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadDataKategori(); //reload atau refresh tampilan data di dataGridView
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //edit
            {
                kategoricreate frm = new kategoricreate();
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Text = "Edit data kategori";
                frm.id_kategori = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                frm.txtnama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtharga.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Tambahkan baris baru setelah diedit
                    int newIndex = dataGridView1.Rows.Add();
                    dataGridView1.Rows[newIndex].Cells[0].Value = frm.id_kategori.ToString();
                    dataGridView1.Rows[newIndex].Cells[1].Value = frm.txtnama.Text;
                    dataGridView1.Rows[newIndex].Cells[2].Value = frm.txtharga.Text;
                    dataGridView1.Rows[newIndex].Cells[3].Value = "Edit";
                    dataGridView1.Rows[newIndex].Cells[4].Value = "Delete";
                }
            }
            if (e.ColumnIndex == 4) //klik delete
            {
                //konfirmasi dulu sebelumm hapus

                if (MessageBox.Show("Apakah yakin menghapus kategori ini?", "Konfirmasi",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                try
                {
                    string id_kategori_dihapus = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //koneksi ke database 
                    Koneksi.buka();

                    //buat command sql delete
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Koneksi.sqlConn;
                    cmd.CommandText = "DELETE FROM kategori WHERE id_kategori = @pID";
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
    
    

