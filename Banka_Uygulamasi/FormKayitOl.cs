using System.Data.SqlClient;

namespace Banka_Uygulamasi
{
    public partial class FormKayitOl : Form
    {
        public FormKayitOl()
        {
            InitializeComponent();
        }

        string HesapNo = "0";
        SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbBanka;Integrated Security=True");

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mskTCKimlik.Clear();
            mskTelefon.Clear();
            HesapNoUret();
            txtSifre.Clear();
            txtAd.Focus();
        }

        void HesapNoUret()
        {
            HesapNo = "0";
            Random rnd = new Random();
            string degisken = rnd.Next(100000, 1000000).ToString();
            while (HesapNoKontrol(degisken))
            {
                degisken = rnd.Next(100000, 1000000).ToString();
            }
            HesapNo = degisken;
            mskHesapNo.Text = HesapNo;
        }

        bool HesapNoKontrol(string degisken)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select Count(*) from tbl_Kisiler where HesapNo=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", degisken);
            int kayitSayisi = (int)cmd.ExecuteScalar();
            cnn.Close();
            if (kayitSayisi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void FormKayitOl_Load(object sender, EventArgs e)
        {
            HesapNoUret();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (HesapNo != "0" && txtAd.Text != "" && txtSoyad.Text != "" && mskTCKimlik.Text.Length == 11 && mskTelefon.Text != "" && txtSifre.Text != "")
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("insert into tbl_Kisiler (Ad,Soyad,TC,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", cnn);
                cmd.Parameters.AddWithValue("@p1", txtAd.Text);
                cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@p3", mskTCKimlik.Text);
                cmd.Parameters.AddWithValue("@p4", mskTelefon.Text);
                cmd.Parameters.AddWithValue("@p5", HesapNo);
                cmd.Parameters.AddWithValue("@p6", txtSifre.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();

                cnn.Open();
                SqlCommand cmd2 = new SqlCommand("insert into tbl_Hesap (HesapNo,Bakiye) values (@p1,@p2)", cnn);
                cmd2.Parameters.AddWithValue("@p1", HesapNo);
                cmd2.Parameters.AddWithValue("@p2", 0);
                cmd2.ExecuteNonQuery();
                cnn.Close();

                MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi");
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Kontrol Edin!");
            }

        }

        private void FormKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGiris giris = new FormGiris();
            giris.Show();
            this.Hide();
        }
    }
}
