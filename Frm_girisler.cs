namespace Proje_Hastahane
{
    public partial class Frm_girisler : Form
    {
        public Frm_girisler()
        {
            InitializeComponent();
        }

        private void btnhastailkgiris_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hastaGiris = new FrmHastaGiris();
            hastaGiris.Show();
            this.Hide();
        }

        private void btindoktorilkgiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris doktorGiris = new FrmDoktorGiris();
            doktorGiris.Show();
            this.Hide();
        }

        private void btnsekreterilkgiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sekreterGiris = new FrmSekreterGiris();
            sekreterGiris.Show();
            this.Hide();

        }

        private void Frm_girisler_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}