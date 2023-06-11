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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string tcnumara;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;
            /*--------------------------------------------------------------------------------------------------------*/
            //adsoyad çekme işlemi
            /*--------------------------------------------------------------------------------------------------------*/
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreter" +
                " where SekreterTC=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0].ToString();
            }
            bgl.Baglanti().Close();
            /*--------------------------------------------------------------------------------------------------------*/
            //Branşları çekme işlemi
            /*--------------------------------------------------------------------------------------------------------*/
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar"
                , bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*--------------------------------------------------------------------------------------------------------*/
            // doktor bilgilerini çekme 
            /*--------------------------------------------------------------------------------------------------------*/
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select*from Tbl_Doktorlar"
                , bgl.Baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //combobox içerisine branş çekme 
            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.Baglanti());
            IDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0].ToString());
            }
            bgl.Baglanti().Close();
            /*--------------------------------------------------------------------------------------------------------*/
















        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular" +
           "(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values(@p1,@p2,@p3,@p4)", bgl.Baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.Baglanti().Close();
            MessageBox.Show("RANDEVU OLUŞTURULDU", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            cmbdoktor.Text = "";
            SqlCommand komut3 = new SqlCommand("select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.Baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

                cmbdoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.Baglanti().Close();
        }


        private void btnolustur_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (DuyuruText) values(@p1)", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", richTextBox1.Text);
            komut.ExecuteNonQuery();
            bgl.Baglanti().Close();
            if (richTextBox1.Text == "")
            {
                btnolustur.Enabled = false;
            }
            else
            {
                MessageBox.Show("Duyuru oluşturuldu", "Bilgi", MessageBoxButtons.
                               OK, MessageBoxIcon.Information);
                richTextBox1.Text = "";
            }


        }

        private void btndoktorislem_Click(object sender, EventArgs e)
        {
            Frmdoktorislem di = new Frmdoktorislem();
            di.Show();

        }

        private void btnbransislem_Click(object sender, EventArgs e)
        {
            Frmbransislem bi = new Frmbransislem();
            bi.Show();

        }

        private void btnrandevuislem_Click(object sender, EventArgs e)
        {
            Frmrandevuislem ri = new Frmrandevuislem();
            ri.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular duy = new FrmDuyurular();
            duy.Show();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from Tbl_Randevular where RandevuBrans='" +
                cmbbrans.Text + "'and RandevuDoktor='" + cmbdoktor.Text + "'and RandevuDurum=0 ", bgl.Baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }
    }
}
