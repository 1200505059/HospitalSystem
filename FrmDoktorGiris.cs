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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay dd = new FrmDoktorDetay();
                dd.TC = msktc.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC veya Sifre Hatalı", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.Baglanti().Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_girisler grs = new Frm_girisler();
            grs.Show();
            this.Hide();
        }
    }
}
