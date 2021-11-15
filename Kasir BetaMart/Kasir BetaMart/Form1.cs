using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_BetaMart
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\kasirbetamart.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSImpan_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into kasirbetamart (ID,Kode_Barang,Nama_Barang ,Harga) values('"+ txtID.Text +"','" + txtKode.Text + "','" + txtNama.Text + "','" + txtHarga.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Disimpan.");

            clearText();
            fillgrid();
        }
        void fillgrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from kasirbetamart order by ID", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update kasirbetamart set ID  ='" + txtID.Text + "',Kode_Barang ='" + txtKode.Text + "', Nama_Barang = '" + txtNama.Text + "',Harga = '" + txtHarga.Text + "' where ID = '" + txtID.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Diubah.");

            clearText();
            fillgrid();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("delete from kasirbetamart where ID ='" + txtID.Text + "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Berhasil Dihapus.");

            clearText();
            fillgrid();
        }

        void clearText()
        {
            txtID.Text = "";
            txtKode.Text = "";
            txtNama.Text = "";
            txtHarga.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePart = openFileDialog1.FileName;
            pictureBox.Image = Image.FromFile(filePart);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            
        }
        void TampilBarang()
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
