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
using System.Linq.Expressions;

namespace YurtOtomasyonu
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
       
        private void txtOgrAd_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Öğrenci Silme

            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where ogrenciId=@k1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", textBoxID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
        }

        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set ogrenciAd=@p2,ogrenciSoyad=@p3,ogrenciTC=@p4,ogrenciTel=@p5,odaNo=@p6,ogrenciDogum=@p7,ogrenciBolum=@p8,ogrenciMail=@p9,ogrenciAdres=@p10 where ogrenciID=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textBoxID.Text);
                komut.Parameters.AddWithValue("@p2", textOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", textOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTC.Text);
                komut.Parameters.AddWithValue("@p5", mskTel.Text);
                komut.Parameters.AddWithValue("@p6", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p7", mskDogumTar.Text);
                komut.Parameters.AddWithValue("@p8", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p9", textMail.Text);
                komut.Parameters.AddWithValue("@p10", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
            }
            catch
            {
                MessageBox.Show("Hata,Yeniden Deneyiniz");
            }
            
        }
        public string id, ad, soyad, TC, telefon, odaNo, dogumTarihi, bolum, mail, adres;
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        { //Bölümleri Listeleme
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

            textBoxID.Text = id;
            textOgrAd.Text = ad;
            textOgrSoyad.Text = soyad;
            mskTC.Text = TC;
            mskTel.Text = telefon;
            cmbOdaNo.Text = odaNo;
            mskDogumTar.Text = dogumTarihi;
            cmbBolum.Text = bolum;
            textMail.Text = mail;
            rchAdres.Text = adres;

        }
    }
}
