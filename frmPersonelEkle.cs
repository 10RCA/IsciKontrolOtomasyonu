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

namespace IsciKontrolOtomasyonu
{
    public partial class frmPersonelEkle : Form
    {
        Veritabani baglan = new Veritabani();
        public void ESG(SqlCommand cmd, string sql)
        {
            SqlConnection baglanti = new SqlConnection(baglan.Adres);
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public frmPersonelEkle()
        {
            InitializeComponent();
        }
        Personeller Personeller = new Personeller();
        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            Personeller.ComboyaKayitGetir(comboDepartman);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Temizle()
        {
            dateTimePickerGirisTarihi.Value = DateTime.Now;
            comboDepartman.Text = "";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
           
            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;

            string sorgu = "insert into Personeller(Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maasi,GirisTarihi,Aciklama) values('"+p.Adi+"'," +
                "'"+p.Soyadi+"','"+p.Telefon+"','"+p.Adres+"','"+p.Email+"','"+p.DepartmanID+"',@Maasi,@GirisTarihi,'"+p.Aciklama+"')";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;


            ESG(komut,sorgu);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Personeller p = new Personeller();

            p.Adi = txtAdi.Text;
            p.Soyadi = txtSoyadi.Text;
            p.Telefon = txtTelefon.Text;
            p.Adres = txtAdres.Text;
            p.Email = txtEmail.Text;
            p.DepartmanID = (int)comboDepartman.SelectedValue;
            p.Maasi = decimal.Parse(txtMaasi.Text);
            p.GirisTarihi = dateTimePickerGirisTarihi.Value;
            p.Aciklama = txtAciklama.Text;

            string sorgu = "insert into Personeller(Adi,Soyadi,Telefon,Adres,Email,DepartmanID,Maasi,GirisTarihi,Aciklama) values('" + p.Adi + "'," +
                "'" + p.Soyadi + "','" + p.Telefon + "','" + p.Adres + "','" + p.Email + "','" + p.DepartmanID + "',@Maasi,@GirisTarihi,'" + p.Aciklama + "')";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Maasi", SqlDbType.Decimal).Value = p.Maasi;
            komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;


            ESG(komut, sorgu);
            Temizle();
            MessageBox.Show("İşlem Başarılı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
