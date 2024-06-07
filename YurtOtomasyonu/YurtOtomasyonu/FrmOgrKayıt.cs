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
    public partial class FrmOgrKayıt : Form
    {
        public FrmOgrKayıt()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme
            SqlCommand komut = new SqlCommand("Select bolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş odaları listeleme
            SqlCommand komut2 = new SqlCommand("Select odaNo From Odalar where odaKapasite != odaKalan", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(ogrenciAd,ogrenciSoyad,ogrenciTC,ogrenciTel,odaNo,ogrenciDogum,ogrenciBolum,ogrenciMail,ogrenciAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", textOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", textOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", mskTel.Text);
                komutkaydet.Parameters.AddWithValue("@p5", cmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p6", mskDogumTar.Text);
                komutkaydet.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komutkaydet.Parameters.AddWithValue("@p8", textMail.Text);
                komutkaydet.Parameters.AddWithValue("@p9", rchAdres.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi");

                //Öğrenci id yi Labele Çekme
                SqlCommand komut = new SqlCommand("select ogrenciID from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label1.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                //Öğrenci borç alanı oluşturma
                SqlCommand komutkaydet2= new SqlCommand("insert into Odemeler (ogrenciID,ogrenciAd,ogrenciSoyad) values (@b1,@b2,@b3)",bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label1.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", textOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", textOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("HATA, Lütfen Yeniden Deneyiniz");
            }
        }

        private void FrmOgrKayıt_ImeModeChanged(object sender, EventArgs e)
        {

        }

        private void cmbOdaNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void mskDogumTar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
