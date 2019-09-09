using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KitapListelefrm kitaplistele = new KitapListelefrm();
            kitaplistele.ShowDialog();
            EmanetKitapVerfrm emanetkitapver = new EmanetKitapVerfrm();
            emanetkitapver.ShowDialog();
        }
        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapekle = new KitapEklefrm();
            kitapekle.ShowDialog();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            ÜyeEklefrm uyeekle = new ÜyeEklefrm();
            uyeekle.ShowDialog();
        }

        private void btnÜyeListele_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyeliste = new UyeListelemefrm();
            uyeliste.ShowDialog();
        }
    }

    
}
