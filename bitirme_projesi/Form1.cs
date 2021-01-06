using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitirme_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ButtonlarıAktifEt(bool aktifMi)
        {
            btnSil.Enabled = aktifMi;
            btnGuncelle.Enabled = aktifMi;

        }
        
        Personel person(Personel kisi)
        {
            kisi.TC = txtTcKimlikNo.Text;
            kisi.Adi = txtAd.Text;
            kisi.Soyadi = txtSoyad.Text;
           
            kisi.TelefonNo = txtTelefon.Text;
            kisi.DogumTarihi = dtDogumTarihi.Value;
            kisi.İseGirisTarihi = dtIseGirisTarihi.Value;
            kisi.Mail = txtEmail.Text;
            kisi.Adres = txtAdres.Text;
        
            kisi.unv = (Unvan)Enum.Parse(typeof(Unvan), cmbUnvan.Text);
            return kisi;

        }
        ListViewItem doldur(Personel kisi)
        {
            ListViewItem bir = new ListViewItem(kisi.TC);
            
            bir.SubItems.Add(kisi.Adi);
            bir.SubItems.Add(kisi.Soyadi);
            bir.SubItems.Add(kisi.İseGirisTarihi.ToString());
            bir.SubItems.Add(kisi.TelefonNo);
            bir.SubItems.Add(kisi.Mail);
            

            return bir;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimSec = new OpenFileDialog();
            resimSec.Title = "Resim seçiniz";
            resimSec.Filter = "başlık |*.png;*.jpg;*.bmp";
            resimSec.ShowDialog();
            string DosyaYolu = resimSec.FileName;
            pictureBox_resim.ImageLocation = DosyaYolu;
        }
        Temizlik silSupur = new Temizlik();
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            silSupur.Temizle(groupBoxPersonelBilgileriAlani.Controls);
            ButtonlarıAktifEt(false);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ButtonlarıAktifEt(true);

            Personel kisi = new Personel();
            kisi = person(kisi);

            ListViewItem lst = doldur(kisi);
           
            lstW_tablo.Items.Add(lst);
            
            

            silSupur.Temizle(groupBoxPersonelBilgileriAlani.Controls);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvan)));
        }
        Personel guncelle = new Personel();
        int indexNo;
        private void lstW_tablo_DoubleClick(object sender, EventArgs e)
        {
            indexNo = lstW_tablo.SelectedItems[0].Index;
            guncelle = (Personel)lstW_tablo.SelectedItems[0].Tag;

            
            txtAd.Text = guncelle.Adi;
            txtSoyad.Text = guncelle.Soyadi;
            txtEmail.Text = guncelle.Mail;
            txtTelefon.Text = guncelle.TelefonNo;
            txtAdres.Text = guncelle.Adres;
            dtDogumTarihi.Value = guncelle.DogumTarihi;
            dtIseGirisTarihi.Value = guncelle.İseGirisTarihi;
            cmbUnvan.Text = guncelle.unv.ToString();

            ButtonlarıAktifEt(true);
       
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            guncelle = person(guncelle);
            lstW_tablo.Items.RemoveAt(indexNo);
            lstW_tablo.Items.Insert(indexNo, doldur(guncelle));

        }
    }
}
