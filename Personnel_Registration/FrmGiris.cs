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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MYRAT\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");


        private void FrmGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtKullanici.Text);
            komut.Parameters.AddWithValue("@p2",TxtPassword.Text);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanici Adı Yada Şifre","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
