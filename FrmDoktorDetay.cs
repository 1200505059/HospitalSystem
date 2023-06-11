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

namespace Proje_Hastahane
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbldoktortc.Text = TC;

            // doktor ad soyad çekme 
            SqlCommand komut = new SqlCommand("select DoktorAd ,DoktorSoyad from Tbl_Doktorlar" +
                " where DoktorTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lbldoktortc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbldoktoradsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.Baglanti().Close();

            //doktor randevu çekme 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular Where" +
                " RandevuDoktor='" + lbldoktoradsoyad.Text + "' and RandevuDurum=1", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle dbd = new FrmDoktorBilgiDüzenle();
            dbd.TCNO = lbldoktortc.Text;
            dbd.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fd = new FrmDuyurular();
            fd.Show();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Text = "";
            rchsikayet.Text = "";
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad,HastaTC From Tbl_Hastalar Where HastaTC=@p1 ", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[6].Value.ToString());

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                richTextBox1.Text = "Ad Soyad: " + dr["HastaAd"].ToString() + " " + dr["HastaSoyad"].ToString() + "\nTC: " + dr["HastaTC"].ToString();

            }
            bgl.Baglanti().Close();



        }

        private void rchsikayet_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_girisler grs=new Frm_girisler();
            grs.Show();
            this.Hide();
        }
    }
}
