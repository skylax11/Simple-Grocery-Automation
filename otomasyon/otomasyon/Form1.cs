using System;
using otomasyon.controller;
using System.Collections.Generic;
using System.ComponentModel;
using otomasyon.enumaration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            loginStatus result = controller.login(txt_ka.Text, txt_sifre.Text);
            if (result == loginStatus.basarili)
            {
                MessageBox.Show("Giriş Yapıldı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (controller.getAccess(txt_ka.Text) == "admin")
                {
                    this.Hide();
                    Admin admin = new Admin();
                    admin.Show();

                }
                else if (controller.getAccess(txt_ka.Text) == "kasiyer")
                {
                    this.Hide();
                    Kasiyer kasiyer = new Kasiyer();
                    kasiyer.Show();

                }



            }
            else if (result == loginStatus.basarisiz)
            {
                MessageBox.Show("Giriş Başarısız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Lütfen Boş Yer Bırakmayınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sifreDegistir sd = new sifreDegistir();
            this.Hide();
            sd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
