namespace Banka_Uygulamasi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

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
    }
}