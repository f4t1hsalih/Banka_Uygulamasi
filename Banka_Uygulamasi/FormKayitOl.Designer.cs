namespace Banka_Uygulamasi
{
    partial class FormKayitOl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            mskTCKimlik = new MaskedTextBox();
            mskTelefon = new MaskedTextBox();
            txtSifre = new TextBox();
            label6 = new Label();
            btnKaydet = new Button();
            mskHesapNo = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 15);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 10;
            label1.Text = "Ad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 48);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "Soyad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 81);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "TC Kimlik: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 147);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 14;
            label4.Text = "Hesap No: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 180);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 15;
            label5.Text = "Şifre: ";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(107, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(138, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(107, 45);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(138, 27);
            txtSoyad.TabIndex = 1;
            // 
            // mskTCKimlik
            // 
            mskTCKimlik.Location = new Point(107, 78);
            mskTCKimlik.Mask = "00000000000";
            mskTCKimlik.Name = "mskTCKimlik";
            mskTCKimlik.Size = new Size(138, 27);
            mskTCKimlik.TabIndex = 2;
            mskTCKimlik.ValidatingType = typeof(int);
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(107, 111);
            mskTelefon.Mask = "(999) 000-0000";
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(138, 27);
            mskTelefon.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(107, 177);
            txtSifre.MaxLength = 15;
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(138, 27);
            txtSifre.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 114);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 13;
            label6.Text = "Telefon: ";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(118, 210);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(96, 35);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // mskHesapNo
            // 
            mskHesapNo.Location = new Point(107, 144);
            mskHesapNo.Mask = "000000";
            mskHesapNo.Name = "mskHesapNo";
            mskHesapNo.Size = new Size(138, 27);
            mskHesapNo.TabIndex = 4;
            mskHesapNo.ValidatingType = typeof(int);
            // 
            // FormKayitOl
            // 
            AcceptButton = btnKaydet;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(269, 268);
            Controls.Add(mskHesapNo);
            Controls.Add(btnKaydet);
            Controls.Add(label6);
            Controls.Add(txtSifre);
            Controls.Add(mskTelefon);
            Controls.Add(mskTCKimlik);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormKayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            FormClosed += FormKayitOl_FormClosed;
            Load += FormKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private MaskedTextBox mskTCKimlik;
        private MaskedTextBox mskTelefon;
        private TextBox txtSifre;
        private Label label6;
        private Button btnKaydet;
        private MaskedTextBox mskHesapNo;
    }
}