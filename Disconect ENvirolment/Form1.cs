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

namespace Disconect_ENvirolment
{
    public partial class Form1 : Form
    {
        private string stringConnection = "data source=DESKTOP-HHF2QO3\\LEBEE;" +
            "database+Activity6;User ID sa;Password=Lambang12";
        private SqlConnection koneksi;
        private String kstr;
        private void refreshform()
        {
            nmp.Text = "";
            nmp.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            refreshform();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView();
            btnOpen.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            koneksi.Open();
            string str = "select Nama_Prodi from dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void nmp_Click(object sender, EventArgs e)
        {
            string nmProdi = nmp.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Prodi (Nama_Prodi)" + "values(@Id)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("Id", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridView1();
                refreshform();
            }
    }
}

