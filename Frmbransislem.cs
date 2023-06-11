using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace Proje_Hastahane
{
    public partial class Frmbransislem : Form
    {
        public Frmbransislem()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Frmbransislem_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select*from Tbl_Branslar", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values(@p1)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtbransad.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.
                                       OK, MessageBoxIcon.Information);
            Frmbransislem bi = new Frmbransislem();
            bi.Show();
            this.Hide();



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete  from Tbl_Branslar where BransAd= @p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtbransad.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Branş silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frmbransislem dokt = new Frmbransislem();
            dokt.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtbransİD.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Branslar SET BransAd= @d1 where BransİD=@d2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@d1", txtbransad.Text);
            komut.Parameters.AddWithValue("@d2", txtbransİD.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Branş güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frmbransislem di = new Frmbransislem();
            di.Show();
            this.Hide();
        }
    }
}
