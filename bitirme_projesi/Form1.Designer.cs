namespace bitirme_projesi
{
    partial class Form1
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
            this.groupBoxPersonelBilgileriAlani = new System.Windows.Forms.GroupBox();
            this.pictureBox_resim = new System.Windows.Forms.PictureBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstW_tablo = new System.Windows.Forms.ListView();
            this.column_tc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_iseGirisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_e_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxPersonelBilgileriAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonelBilgileriAlani
            // 
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.pictureBox_resim);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.btnSil);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.btnGuncelle);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.btnEkle);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.btnResimSec);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.cmbUnvan);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label9);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.dtIseGirisTarihi);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label10);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label8);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.dtDogumTarihi);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtAdres);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtEmail);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtTelefon);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtSoyad);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtAd);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.txtTcKimlikNo);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label7);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label6);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label5);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label4);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label3);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label2);
            this.groupBoxPersonelBilgileriAlani.Controls.Add(this.label1);
            this.groupBoxPersonelBilgileriAlani.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonelBilgileriAlani.Name = "groupBoxPersonelBilgileriAlani";
            this.groupBoxPersonelBilgileriAlani.Size = new System.Drawing.Size(722, 256);
            this.groupBoxPersonelBilgileriAlani.TabIndex = 1;
            this.groupBoxPersonelBilgileriAlani.TabStop = false;
            this.groupBoxPersonelBilgileriAlani.Text = "Personel Bilgileri";
            // 
            // pictureBox_resim
            // 
            this.pictureBox_resim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_resim.Location = new System.Drawing.Point(401, 94);
            this.pictureBox_resim.Name = "pictureBox_resim";
            this.pictureBox_resim.Size = new System.Drawing.Size(135, 154);
            this.pictureBox_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_resim.TabIndex = 15;
            this.pictureBox_resim.TabStop = false;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(550, 215);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 36);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(550, 176);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 36);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(550, 137);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 36);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(550, 98);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(138, 36);
            this.btnResimSec.TabIndex = 11;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(550, 64);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(138, 24);
            this.cmbUnvan.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, -64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "İşe Giriş Tarihi : ";
            // 
            // dtIseGirisTarihi
            // 
            this.dtIseGirisTarihi.Location = new System.Drawing.Point(550, 32);
            this.dtIseGirisTarihi.Name = "dtIseGirisTarihi";
            this.dtIseGirisTarihi.Size = new System.Drawing.Size(138, 22);
            this.dtIseGirisTarihi.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ünvan : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "İşe Giriş Tarihi : ";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(162, 128);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(138, 22);
            this.dtDogumTarihi.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(162, 226);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(138, 22);
            this.txtAdres.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(162, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(138, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(162, 162);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(138, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(162, 98);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(138, 22);
            this.txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(162, 66);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(138, 22);
            this.txtAd.TabIndex = 7;
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(162, 34);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(138, 22);
            this.txtTcKimlikNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "E - mail : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No : ";
            // 
            // lstW_tablo
            // 
            this.lstW_tablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_tc,
            this.column_Ad,
            this.column_Soyad,
            this.column_iseGirisTarihi,
            this.column_tel,
            this.column_e_mail});
            this.lstW_tablo.FullRowSelect = true;
            this.lstW_tablo.Location = new System.Drawing.Point(12, 287);
            this.lstW_tablo.Name = "lstW_tablo";
            this.lstW_tablo.Size = new System.Drawing.Size(732, 231);
            this.lstW_tablo.TabIndex = 2;
            this.lstW_tablo.UseCompatibleStateImageBehavior = false;
            this.lstW_tablo.View = System.Windows.Forms.View.Details;
            this.lstW_tablo.DoubleClick += new System.EventHandler(this.lstW_tablo_DoubleClick);
            // 
            // column_tc
            // 
            this.column_tc.Text = "TC NO";
            // 
            // column_Ad
            // 
            this.column_Ad.Text = "AD";
            // 
            // column_Soyad
            // 
            this.column_Soyad.Text = "SOYAD";
            // 
            // column_iseGirisTarihi
            // 
            this.column_iseGirisTarihi.Text = "İşe Giriş Tarihi";
            // 
            // column_tel
            // 
            this.column_tel.Text = "Telefon";
            // 
            // column_e_mail
            // 
            this.column_e_mail.Text = "E-Mail";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 527);
            this.Controls.Add(this.lstW_tablo);
            this.Controls.Add(this.groupBoxPersonelBilgileriAlani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonelBilgileriAlani.ResumeLayout(false);
            this.groupBoxPersonelBilgileriAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonelBilgileriAlani;
        private System.Windows.Forms.PictureBox pictureBox_resim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtIseGirisTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstW_tablo;
        private System.Windows.Forms.ColumnHeader column_tc;
        private System.Windows.Forms.ColumnHeader column_Ad;
        private System.Windows.Forms.ColumnHeader column_Soyad;
        private System.Windows.Forms.ColumnHeader column_iseGirisTarihi;
        private System.Windows.Forms.ColumnHeader column_tel;
        private System.Windows.Forms.ColumnHeader column_e_mail;
    }
}

