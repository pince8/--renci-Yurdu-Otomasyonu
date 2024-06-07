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

namespace YurtOtomasyonu
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonuDataSet8.Odemeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.odemelerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Odemeler);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBoxID.Text = id;
            textBoxAd.Text = ad;
            textBoxSoyad.Text = soyad;
            textBoxKalan.Text = kalan;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int odenen, kalan, yeniBorc;
            odenen = Convert.ToInt16(textBoxOdenen.Text);
            kalan = Convert.ToInt16(textBoxKalan.Text);
            yeniBorc = kalan - odenen;
            textBoxKalan.Text = yeniBorc.ToString();


            SqlCommand komut = new SqlCommand("update Odemeler set  ogrKalanBorc=@p1 where ogrenciID=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", textBoxID.Text);
            komut.Parameters.AddWithValue("@p1", textBoxKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borc odendi");
            this.odemelerTableAdapter.Fill(this.yurtOtomasyonuDataSet8.Odemeler);
        }
    }
}
