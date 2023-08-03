namespace Banka_Uygulamasi
{
    partial class FormHesapHareketleri
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
            dgwGelenMiktar = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dgwGonderilenMiktar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwGelenMiktar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwGonderilenMiktar).BeginInit();
            SuspendLayout();
            // 
            // dgwGelenMiktar
            // 
            dgwGelenMiktar.AllowUserToAddRows = false;
            dgwGelenMiktar.AllowUserToDeleteRows = false;
            dgwGelenMiktar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwGelenMiktar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwGelenMiktar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGelenMiktar.Location = new Point(3, 24);
            dgwGelenMiktar.Margin = new Padding(3, 4, 3, 4);
            dgwGelenMiktar.Name = "dgwGelenMiktar";
            dgwGelenMiktar.ReadOnly = true;
            dgwGelenMiktar.RowTemplate.Height = 25;
            dgwGelenMiktar.Size = new Size(388, 332);
            dgwGelenMiktar.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgwGelenMiktar);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(394, 360);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gelen Miktarlar (+)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgwGonderilenMiktar);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(412, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(388, 360);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gönderilen Miktarlar (-)";
            // 
            // dgwGonderilenMiktar
            // 
            dgwGonderilenMiktar.AllowUserToAddRows = false;
            dgwGonderilenMiktar.AllowUserToDeleteRows = false;
            dgwGonderilenMiktar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwGonderilenMiktar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwGonderilenMiktar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwGonderilenMiktar.Location = new Point(3, 24);
            dgwGonderilenMiktar.Margin = new Padding(3, 4, 3, 4);
            dgwGonderilenMiktar.Name = "dgwGonderilenMiktar";
            dgwGonderilenMiktar.ReadOnly = true;
            dgwGonderilenMiktar.RowTemplate.Height = 25;
            dgwGonderilenMiktar.Size = new Size(382, 332);
            dgwGonderilenMiktar.TabIndex = 0;
            // 
            // FormHesapHareketleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(812, 386);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimumSize = new Size(828, 425);
            Name = "FormHesapHareketleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Hareketleri";
            Load += FormHesapHareketleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgwGelenMiktar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgwGonderilenMiktar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwGelenMiktar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgwGonderilenMiktar;
    }
}