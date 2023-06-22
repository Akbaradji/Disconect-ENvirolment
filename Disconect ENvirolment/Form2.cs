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
    public partial class Form2 : Form
    {
        private string stringConnection = "data source=DESKTOP-HHF2QO3\\LEBEE;" +
           "database+Activity6;User ID sa;Password=Lambang12";
        private string nim, nama, alamat, jk, prodi;
        private SqlConnection koneksi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();
        private string kstr;
        private object bnMahasiswa;
        private object mahasiswaTableAdapter;
        private object data_MahasiswaDataSet1;
        

        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(kstr);
            this.bnMahasiswa.BindingSource = this.customersBindingSource;
            refreshform();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtNIM.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.cbxJenisKelamin.DataBindings.Clear();
            this.dtTanggalLahir.DataBindings.Clear();
            this.cbxProdi.DataBindings.Clear();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxProdi_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string str = "select nama_prodi from dbo.Prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxProdi.DisplayMember = "nama_prodi";
            cbxProdi.ValueMember = "id_prodi";
            cbxProdi.DataSource = ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            cbxProdi_Click();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtNIM.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            dtTanggalLahir.Value = DateTime.Today;
            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            cbxJenisKelamin.Enabled = true;
            txtAlamat.Enabled = true;
            txtAlamat.Enabled = true;
            dtTanggalLahir.Enabled = true;
            cbxProdi.Enabled = true;
            cbxProdi_Click();
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void cbxProdi_Click()
        {
            throw new NotImplementedException();
        }

        private void FormDataMahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_MahasiswaDataSet1.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.data_MahasiswaDataSet1.Mahasiswa);
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, m.alamat, " +
                "m.jenis_kelamin, m.tgl_lahir,p.nama_prodi From dbo.Mahasiswa, " +
                "join dbo.Prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNIM.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "NIM", true));
            this.txtNama.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtAlamat.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "alamat", true));
            this.cbxJenisKelamin.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "jenis_kelamin", true));
            this.dtTanggalLahir.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbxProdi.DataBindings.Add(
                new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();
        }
        private void refreshform()
        {
            txtNIM.Enabled = false;
            txtNama.Enabled = false;
            cbxJenisKelamin.Enabled = false;
            txtAlamat.Enabled = false;
            dtTanggalLahir.Enabled = false;
            cbxProdi.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnClear_Click();
            FormDataMahasiswa_Load();
        }

        private void FormDataMahasiswa_Load()
        {
            throw new NotImplementedException();
        }

        private void btnClear_Click()
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
