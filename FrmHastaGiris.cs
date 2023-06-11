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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();



        private void btnuyeol_Click(object sender, EventArgs e)
        {
            FrmHastaKayit hk = new FrmHastaKayit();
            hk.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay hd = new FrmHastaDetay();
                hd.tc = msktc.Text;

                hd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI ŞİFRE VEYA T.C");
            }
            bgl.Baglanti().Close();

        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_girisler grs = new Frm_girisler();
            grs.Show();
            this.Hide();
        }
    }
}
