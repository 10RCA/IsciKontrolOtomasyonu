using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsciKontrolOtomasyonu
{
    class Personeller
    {
        private int _PersonelID;
        private string _Adi;
        private string _Soyadi;
        private string _Telefon;
        private string _Adres;
        private string _Email;
        private int _DepartmanID;
        private decimal _Maasi;
        private DateTime _GirisTarihi;
        private string _Aciklama;

        public int PERSONELID { get => _PersonelID; set => _PersonelID = value; }
        public string Adi { get => _Adi; set => _Adi = value; }
        public string Soyadi { get => _Soyadi; set => _Soyadi = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public decimal Maasi { get => _Maasi; set => _Maasi = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        Veritabani baglan = new Veritabani();
        public DataTable ComboyaKayitGetir(ComboBox combo)
        {
            
            SqlConnection baglanti = new SqlConnection(baglan.Adres);
        
        DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.ValueMember = value;
            combo.DisplayMember = text;

            baglanti.Close();
            return tbl;
        }
        public  DataTable TariheGoreAra(DateTimePicker dt,DataGridView gridview)
        {
            SqlConnection baglanti = new SqlConnection(baglan.Adres);
            DataTable tbl = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter( "select p.PersonelID,p.Adi," +
                           "p.Soyadi,p.Telefon,p.Adres,p.Email, d.Departman, p.Durumu, " +
                           "p.Maasi, p.GirisTarihi,p.Aciklama from Personeller p, " +
                           "Departmanlar d where p.DepartmanID = d.DepartmanID and GirisTarihi=@P1", baglanti);
            adtr.SelectCommand.Parameters.Add("@P1", SqlDbType.Date).Value = dt.Value;
            adtr.Fill(tbl);
            gridview.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public static string sql = "select * from Departmanlar ";
        public static string value = "DepartmanID";
        public static string text = "Departman";
    }
}
