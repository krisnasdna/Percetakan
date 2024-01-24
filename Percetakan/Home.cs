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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Koneksi.buka();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Koneksi.sqlConn;
            cmd.CommandText = "INSERT INTO pelanggan ( nama, no_telp) VALUES ( @pNama, @pNoTelp)";

            cmd.Parameters.AddWithValue("pNama", tbNama.Text);
            cmd.Parameters.AddWithValue("pNoTelp", tbTelp.Text);

            cmd.ExecuteNonQuery();

            Transaksi frm = new Transaksi();
            frm.WindowState = FormWindowState.Maximized;
            
            frm.Show();

            Koneksi.tutup();
            
        }
    }
}
