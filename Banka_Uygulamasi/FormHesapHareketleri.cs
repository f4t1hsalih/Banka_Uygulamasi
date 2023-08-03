using System.Data;
using System.Data.SqlClient;

namespace Banka_Uygulamasi
{
    public partial class FormHesapHareketleri : Form
    {
        public FormHesapHareketleri()
        {
            InitializeComponent();
        }

        public string HesapNo;
        SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=krsDbBanka;Integrated Security=True");

        private void FormHesapHareketleri_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select (K.Ad + ' ' + K.Soyad) as 'İsim', H.Tutar  from tbl_Hareketler H inner join tbl_Kisiler K on H.GonderenHN = K.HesapNo where H.AliciHN = " + HesapNo, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwGelenMiktar.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select (K.Ad + ' ' + K.Soyad) as ' İsim', H.Tutar from tbl_Hareketler H inner join tbl_Kisiler K on H.AliciHN = K.HesapNo where H.GonderenHN = " + HesapNo, cnn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dgwGonderilenMiktar.DataSource = dt2;
        }

    }
}
