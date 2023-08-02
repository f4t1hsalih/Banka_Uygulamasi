namespace Banka_Uygulamasi
{
    partial class FormIslemler
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
            lblAdSoyad = new Label();
            lblHesapNo = new Label();
            lblTelefon = new Label();
            lblTCKimlikNo = new Label();
            groupBox1 = new GroupBox();
            btnGonder = new Button();
            txtTutar = new TextBox();
            label9 = new Label();
            mskHesapNo = new MaskedTextBox();
            label10 = new Label();
            lblBakiye = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 23);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 53);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Hesap No: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 85);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 118);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "TC Kimlik: ";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(172, 23);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(36, 20);
            lblAdSoyad.TabIndex = 4;
            lblAdSoyad.Text = "Null";
            // 
            // lblHesapNo
            // 
            lblHesapNo.AutoSize = true;
            lblHesapNo.Location = new Point(172, 53);
            lblHesapNo.Name = "lblHesapNo";
            lblHesapNo.Size = new Size(36, 20);
            lblHesapNo.TabIndex = 5;
            lblHesapNo.Text = "Null";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(172, 85);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(36, 20);
            lblTelefon.TabIndex = 6;
            lblTelefon.Text = "Null";
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.AutoSize = true;
            lblTCKimlikNo.Location = new Point(172, 118);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(36, 20);
            lblTCKimlikNo.TabIndex = 7;
            lblTCKimlikNo.Text = "Null";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGonder);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(mskHesapNo);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 177);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 145);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Havale";
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(112, 96);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(124, 31);
            btnGonder.TabIndex = 14;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(112, 63);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(124, 27);
            txtTutar.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 66);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 12;
            label9.Text = "Tutar: ";
            // 
            // mskHesapNo
            // 
            mskHesapNo.Location = new Point(112, 30);
            mskHesapNo.Mask = "000000";
            mskHesapNo.Name = "mskHesapNo";
            mskHesapNo.Size = new Size(124, 27);
            mskHesapNo.TabIndex = 11;
            mskHesapNo.ValidatingType = typeof(int);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 33);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 9;
            label10.Text = "Hesap No: ";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.Location = new Point(172, 149);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(36, 20);
            lblBakiye.TabIndex = 10;
            lblBakiye.Text = "Null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 149);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 9;
            label6.Text = "Bakiye: ";
            // 
            // FormIslemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(298, 334);
            Controls.Add(lblBakiye);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(lblTCKimlikNo);
            Controls.Add(lblTelefon);
            Controls.Add(lblHesapNo);
            Controls.Add(lblAdSoyad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormIslemler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İşlemler";
            FormClosed += FormIslemler_FormClosed;
            Load += FormIslemler_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAdSoyad;
        private Label lblHesapNo;
        private Label lblTelefon;
        private Label lblTCKimlikNo;
        private GroupBox groupBox1;
        private MaskedTextBox mskHesapNo;
        private Label label10;
        private TextBox txtTutar;
        private Label label9;
        private Button btnGonder;
        private Label lblBakiye;
        private Label label6;
    }
}