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
    public partial class frmDepartmanlar : Form
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
        

        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        Departmanlar DepartmanGetir = new Departmanlar();
        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            
            DepartmanGetir.DepartmanGetir(listView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          

            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama1 = txtAciklama.Text;
            string sorgu = "insert into Departmanlar values('"+d.Departman+"','"+d.Aciklama1+"')";
            SqlCommand komut = new SqlCommand();
            ESG(komut,sorgu);
            MessageBox.Show("İşlem Başarılı.");
            DepartmanGetir.DepartmanGetir(listView1);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama1 = txtAciklama.Text;
            string sorgu ="update departmanlar set departman='" + d.Departman + "',aciklama='"+d.Aciklama1+"'where departmanID='"+d.DepartmanID+"'";
            SqlCommand komut = new SqlCommand();
            ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı.");
            DepartmanGetir.DepartmanGetir(listView1);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count>0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from departmanlar where departmanID='" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı.");
                DepartmanGetir.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Önce kayıt seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDepartman_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text= listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text= listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartmanID_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.Departman = txtDepartman.Text;
            d.Aciklama1 = txtAciklama.Text;
            string sorgu = "insert into Departmanlar values('" + d.Departman + "','" + d.Aciklama1 + "')";
            SqlCommand komut = new SqlCommand();
            ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı.");
            DepartmanGetir.DepartmanGetir(listView1);
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            Departmanlar d = new Departmanlar();
            d.DepartmanID = int.Parse(txtDepartmanID.Text);
            d.Departman = txtDepartman.Text;
            d.Aciklama1 = txtAciklama.Text;
            string sorgu = "update departmanlar set departman='" + d.Departman + "',aciklama='" + d.Aciklama1 + "'where departmanID='" + d.DepartmanID + "'";
            SqlCommand komut = new SqlCommand();
            ESG(komut, sorgu);
            MessageBox.Show("İşlem Başarılı.");
            DepartmanGetir.DepartmanGetir(listView1);
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "delete from departmanlar where departmanID='" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                ESG(komut, sorgu);
                MessageBox.Show("İşlem Başarılı.");
                DepartmanGetir.DepartmanGetir(listView1);
            }
            else
            {
                MessageBox.Show("Önce kayıt seçilmelidir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDepartmanID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtDepartmanID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
