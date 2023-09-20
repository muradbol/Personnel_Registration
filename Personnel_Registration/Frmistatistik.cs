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

namespace Personnel_Registration
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MYRAT\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {
            //PERSONEL SAYİSİ
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count (*) From Personel", baglanti);
            SqlDataReader dr1=komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            } 
            
            baglanti.Close();

            //EVLİ SAYISI
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count (*) From Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblEvliSayi.Text = dr2[0].ToString();
            }
            baglanti.Close();
            //BEKAR SAYİSİ
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count (*) From Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblBekarSayi.Text = dr3[0].ToString();
            }
            baglanti.Close();
            //Şehir Sayisi 
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select count (distinct (PerSehir)) from Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblSehirSayi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //Toplam Maaş
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select SUM (PerMaaas) from Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblTopMaas.Text = dr5[0].ToString();

            }
            baglanti.Close();
            //Ortalama Maaş
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select AVG (PerMaaas) from Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
              LblOrtalamaMaas.Text = dr6[0].ToString();

            }
            baglanti.Close();
        }
    }
}
