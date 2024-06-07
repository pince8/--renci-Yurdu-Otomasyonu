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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int secilen;

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
     
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (bolumAd) values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", textBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata, Yeniden Deneyiniz");
            }
        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where BolumID=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1",textBolumID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch 
            {
                MessageBox.Show("Hata Oluştu" );
            }
        }
        
          
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                string id, bolumad;
                secilen = dataGridView1.SelectedCells[0].RowIndex;
                id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

                textBolumID.Text = id;
                textBolumAd.Text = bolumad;

            }

        private void pcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("update Bolumler Set BolumAd=@p1 where BolumID=@p2", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", textBolumID.Text);
                komut2.Parameters.AddWithValue("@p1", textBolumAd.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonuDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("HATA, İşleminiz Gerçekleşemedi");
            }
        }
    }
    }

