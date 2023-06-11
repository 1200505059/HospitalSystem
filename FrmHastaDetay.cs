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
using System.Windows.Forms.Design.Behavior;

namespace Proje_Hastahane
{
    public partial class FrmHastaDetay : Form
    {
        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();

        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            // Ad soyad çekme
            SqlCommand komut = new SqlCommand("select HastaAd, HastaSoyad from Tbl_Hastalar Where HastaTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.Baglanti().Close();

            // Randevu geçmişi listeleme
            DataTable dt = new DataTable();
            SqlCommand komuts = new SqlCommand("select * from Tbl_Randevular where HastaTC=@p1", bgl.Baglanti());
            komuts.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataAdapter da = new SqlDataAdapter(komuts);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Branş çekme 
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.Baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.Baglanti().Close();
        }

        private void lbladsoyad_Click(object sender, EventArgs e)
        {

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            cmbdoktor.Text = "";

            SqlCommand komut3 = new SqlCommand("select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.Baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where RandevuBrans='" +
                cmbbrans.Text + "' and RandevuDoktor='" + cmbdoktor.Text + "' and RandevuDurum=0", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnhastaguncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnhastaguncel_Click(object sender, EventArgs e)
        {
            HASTABİLGİGÜNCELLE bd = new HASTABİLGİGÜNCELLE();
            bd.tcno = lbltc.Text;
            bd.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            label2.Visible = true;
            txtid.Visible = true;
        }

        private void btnradevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Randevular " +
                "set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbbrans.Text = "";
            cmbdoktor.Text = "";
            rchsikayet.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == true && pictureBox3.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

            }
            else
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_girisler grs = new Frm_girisler();
            grs.Show();
            this.Hide();
        }
    }
}
