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
using System.ComponentModel.Design;

namespace Personnel_Registration
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=MYRAT\\SQLEXPRESS;Initial Catalog=Personel_Veri_Tabani;Integrated Security=True");
        void Temizle()
        {
            TxtAd.Text = "";
            TxtMaas.Text = "";
            TxtMeslek.Text = "";
            TxtSoy.Text  = "";
            Txtİd.Text = "";
            ComboSehir.Text = "";
            Evli.Text = "";
            Bekar.Text = "";
            dataGridView1.ClearSelection();
            TxtAd.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.personelTableAdapter.Fill(this.personel_Veri_TabaniDataSet.Personel);

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            
            this.personelTableAdapter.Fill(this.personel_Veri_TabaniDataSet.Personel);
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Personel (PerAd,PerSoy,PerSehir,PerMaaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoy.Text);
            komut.Parameters.AddWithValue("@p3", ComboSehir.Text);
            komut.Parameters.AddWithValue("@p4", TxtMaas.Text);
           komut.Parameters.AddWithValue("@p5", label8.Text);
            komut.Parameters.AddWithValue("@p6", TxtMeslek.Text);
            

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayit Başarıyla Oluşturuldu. ","Kayit İşlemi ",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
        private void Evli_CheckedChanged(object sender, EventArgs e)
        {
            if (Evli.Checked == true)
            {
                label8.Text = "True";
            }
        }
        private void Bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (Bekar.Checked == true)
            {
                label8.Text = "False";
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtİd.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            ComboSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
           
        }
        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                Evli.Checked = true;
            }
            if (label8.Text == "False")
            {
                Bekar.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil=new SqlCommand("Delete From Personel Where Perid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1",Txtİd.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi","Silme İşlemi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komguncelle = new SqlCommand("UPDATE Personel Set PerAd=@a1,PerSoy=@a2,PerSehir=@a3,PerMaaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perİd=@a7", baglanti);
            komguncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komguncelle.Parameters.AddWithValue("@a2", TxtSoy.Text);
            komguncelle.Parameters.AddWithValue("@a3", ComboSehir.Text);
            komguncelle.Parameters.AddWithValue("@a4", TxtMaas.Text);
            komguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komguncelle.Parameters.AddWithValue("@a7", Txtİd.Text);
            komguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Güncellendi ", "Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr=new Frmistatistik();
            fr.Show();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg=new FrmGrafikler();
            frg.Show();
        }
    }
    }

