using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsciKontrolOtomasyonu
{
    class Departmanlar
    {
        private int _DepartmanID;
        private string _Departman;
        private string Aciklama;
        //ENCAPSULATION İŞLEMİ UYGULADIK 
        public string Aciklama1 { get => Aciklama; set => Aciklama = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        Veritabani baglan = new Veritabani();
        public  SqlDataReader DepartmanGetir(ListView lst)
        {
           SqlConnection baglanti = new SqlConnection(baglan.Adres);
        lst.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Departmanlar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                lst.Items.Add(ekle);
            }
            baglanti.Close();
            return dr;
        }
    }

}
