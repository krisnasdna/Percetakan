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
using System.Data.SqlClient;

namespace Percetakan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtun.Text;
            password = txtpw.Text;
            Koneksi.buka();
            SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM cs WHERE nama = '" + username + "'AND password = '" + password + "'";
                cmd.Connection = Koneksi.sqlConn;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                SqlDataReader rd = cmd.ExecuteReader();
                Koneksi.tutup();
                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("login berhasil");

                    //load next page
                    Kategori form2 = new Kategori();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid login details","error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtun.Clear();
                    txtpw.Clear();

                    txtun.Focus();

                }
            
          
            }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtun.Clear();
            txtpw.Clear();

            txtun.Focus();

        }
    }
    }

