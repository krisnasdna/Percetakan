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
            Transaksi data = new Transaksi();
            data.nama = tbNama.Text;
            data.no_telp = tbTelp.Text;
            data.WindowState = FormWindowState.Maximized;
            data.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
