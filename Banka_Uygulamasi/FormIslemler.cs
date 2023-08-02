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
        SqlConnection cnn = new SqlConnection("Data Source=SALIH\\SQLEXPRESS;Initial Catalog=krsDbBanka;Integrated Security=True");

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
        }
    }
}
