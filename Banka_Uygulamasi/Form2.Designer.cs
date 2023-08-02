namespace Banka_Uygulamasi
{
    partial class Form2
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnGonder = new Button();
            txtTutar = new TextBox();
            label9 = new Label();
            mskHesapNo = new MaskedTextBox();
            label10 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Hesap No: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 102);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 135);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "TC Kimlik: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 32);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "Null";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 70);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 5;
            label6.Text = "Null";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(124, 102);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 6;
            label7.Text = "Null";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(124, 135);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 7;
            label8.Text = "Null";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGonder);
            groupBox1.Controls.Add(txtTutar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(mskHesapNo);
            groupBox1.Controls.Add(label10);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 147);
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(420, 344);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
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
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private MaskedTextBox mskHesapNo;
        private Label label10;
        private TextBox txtTutar;
        private Label label9;
        private Button btnGonder;
    }
}