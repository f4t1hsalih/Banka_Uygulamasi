using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

    }
}
