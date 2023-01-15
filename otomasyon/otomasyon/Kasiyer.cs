using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Kasiyer : Form
    {
        public Kasiyer()
        {
            InitializeComponent();
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            meyveSebze meyvesebze = new meyveSebze();
            this.Hide();
            meyvesebze.Show();

        }

        private void suturunleri_Click(object sender, EventArgs e)
        {

        }

        private void eturunleri_Click(object sender, EventArgs e)
        {

        }

        private void baklagiller_Click(object sender, EventArgs e)
        {

        }

        private void Kasiyer_Load(object sender, EventArgs e)
        {

        }
    }
}
