namespace Banka_Uygulamasi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSifre = new TextBox();
            mskHesapNo = new MaskedTextBox();
            btnGiris = new Button();
            lnkKayitOl = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 41);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 10;
            label1.Text = "Hesap No: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 11;
            label2.Text = "Şifre: ";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(130, 71);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(131, 27);
            txtSifre.TabIndex = 1;
            // 
            // mskHesapNo
            // 
            mskHesapNo.Location = new Point(130, 38);
            mskHesapNo.Mask = "000000";
            mskHesapNo.Name = "mskHesapNo";
            mskHesapNo.Size = new Size(131, 27);
            mskHesapNo.TabIndex = 0;
            mskHesapNo.ValidatingType = typeof(int);
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(150, 104);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(82, 30);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            // 
            // lnkKayitOl
            // 
            lnkKayitOl.AutoSize = true;
            lnkKayitOl.LinkColor = Color.Lime;
            lnkKayitOl.Location = new Point(12, 128);
            lnkKayitOl.Name = "lnkKayitOl";
            lnkKayitOl.Size = new Size(61, 20);
            lnkKayitOl.TabIndex = 12;
            lnkKayitOl.TabStop = true;
            lnkKayitOl.Text = "Kayıt Ol";
            lnkKayitOl.LinkClicked += lnkKayitOl_LinkClicked;
            // 
            // FormGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(330, 157);
            Controls.Add(lnkKayitOl);
            Controls.Add(btnGiris);
            Controls.Add(mskHesapNo);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş";
            FormClosed += FormGiris_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSifre;
        private MaskedTextBox mskHesapNo;
        private Button btnGiris;
        private LinkLabel lnkKayitOl;
    }
}