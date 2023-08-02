using System.Data.SqlClient;

namespace Banka_Uygulamasi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection("Data Source=SALIH\\SQLEXPRESS;Initial Catalog=krsDbBanka;Integrated Security=True");

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKayitOl kayitOl = new FormKayitOl();
            kayitOl.Show();
            this.Hide();
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Kisiler where HesapNo=@p1 and Sifre=@p2", cnn);
            cmd.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FormIslemler islemler = new FormIslemler();
                islemler.HesapNo = mskHesapNo.Text;
                islemler.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Bilgi");
            }

        }

    }
}