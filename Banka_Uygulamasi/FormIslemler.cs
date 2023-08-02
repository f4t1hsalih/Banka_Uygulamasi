using System.Data.SqlClient;

namespace Banka_Uygulamasi
{
    public partial class FormIslemler : Form
    {
        public FormIslemler()
        {
            InitializeComponent();
        }

        public string HesapNo;
        string bakiye;
        SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbBanka;Integrated Security=True");

        void Temizle()
        {
            mskHesapNo.Clear();
            txtTutar.Clear();
        }
        void BakiyeCekme()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select Bakiye from tbl_Hesap where HesapNo=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", HesapNo);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bakiye = dr[0].ToString();
                lblBakiye.Text = bakiye;
            }
            cnn.Close();
        }

        private void FormIslemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGiris giris = new FormGiris();
            giris.Show();
            this.Hide();
        }

        private void FormIslemler_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = HesapNo;

            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Kisiler where HesapNo=@p1", cnn);
            cmd.Parameters.AddWithValue("@p1", HesapNo);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblTCKimlikNo.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();
            }
            cnn.Close();

            BakiyeCekme();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            decimal deger = decimal.Parse(bakiye) - decimal.Parse(txtTutar.Text);
            //MessageBox.Show(deger.ToString());
            if (deger < 0)
            {
                MessageBox.Show("Hesabınızda Olan Paradan Daha Yüksek Bir Miktar Gönderemezsiniz!");
            }
            else
            {
                //Hesaptan Para Eksiltme
                cnn.Open();
                SqlCommand cmd = new SqlCommand("update tbl_Hesap set Bakiye = Bakiye-@p1 where HesapNo=@p2", cnn);
                cmd.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                cmd.Parameters.AddWithValue("@p2", HesapNo);
                cmd.ExecuteNonQuery();
                cnn.Close();

                //Karşı Hesabın Bakiyesini Artırma
                cnn.Open();
                SqlCommand cmd2 = new SqlCommand("update tbl_Hesap set Bakiye = Bakiye+@p1 where HesapNo=@p2", cnn);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
                cmd2.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                cmd2.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("İşlem Gerçekleşti");
                Temizle();

                BakiyeCekme();
            }

        }
    }
}
