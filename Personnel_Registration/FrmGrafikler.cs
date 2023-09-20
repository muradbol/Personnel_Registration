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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MYRAT\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {

            // Grafik 1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Personel Group By PerSehir",baglanti);
            SqlDataReader reader = komutg1.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(reader[0], reader[1]);
            }
            baglanti.Close();

            // Grafik 2 
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,AVG(PerMaaas) From Personel Group By PerMeslek", baglanti);
            SqlDataReader reader1 = komutg2.ExecuteReader();
            while (reader1.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(reader1[0], reader1[1]);
            }
            baglanti.Close();
        }
    }
}
