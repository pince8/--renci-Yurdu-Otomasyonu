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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
       
        private void btnGiris_Click(object sender, EventArgs e)
        {
                SqlCommand komut = new SqlCommand("select * from Admin where yoneticiAd=@p1 and yoneticiSifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", textKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", textSifre.Text);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre");
                    textKullaniciAd.Clear();
                    textSifre.Clear();
                    textKullaniciAd.Focus();
                }
                bgl.baglanti().Close();
            }

        private void textSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
