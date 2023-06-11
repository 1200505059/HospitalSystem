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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select DuyuruText From Tbl_duyurular", bgl.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    int secilen = dataGridView1.SelectedCells[0].RowIndex;
        //    SqlCommand komut = new SqlCommand("Delete From Tbl_Duyurular Where DuyuruİD=@p1",bgl.Baglanti());
        //    komut.Parameters.AddWithValue("@p1", secilen);
        //    komut.ExecuteNonQuery();
        //    bgl.Baglanti().Close();
        //    MessageBox.Show("Duyuru Silindi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //}
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int secilen = dataGridView1.Rows[e.RowIndex].Cells["DuyuruText"].RowIndex;

                SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Duyurular WHERE DuyuruText = @p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", secilen.ToString());
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                dataGridView1.Rows.RemoveAt(e.RowIndex);
                MessageBox.Show("Duyuru Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
