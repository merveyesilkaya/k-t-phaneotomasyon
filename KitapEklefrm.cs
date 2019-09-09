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

namespace WindowsFormsApp7
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GQDIU8GI\\MERVESQL;Initial Catalog=KütühaneOtomasyonu;Integrated Security=True");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitap(barkodno,kitapadi,yazar,yayinevi,sayfasayisi,tur,stoksayisi,rafno,kayittarihi) values(@barkodno,@kitapadi,@yazar,@yayinevi,@sayfasayisi,@tur,@stoksayisi,@rafno,@kayittarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue(@"sayfasayisi", txtsayfasayisi.Text);
            komut.Parameters.AddWithValue(@"tur", comboTur.Text);
            komut.Parameters.AddWithValue("@stoksayisi",txtStokSayisi .Text);
            komut.Parameters.AddWithValue("@rafno", txtRafno.Text);
            komut.Parameters.AddWithValue("kayittarihi", DateTime.Now.ToShortDateString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap KaydI Yapıldı");
           
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }
        }
    }
    
}
