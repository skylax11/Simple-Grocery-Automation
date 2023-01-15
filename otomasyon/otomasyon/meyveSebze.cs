using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using otomasyon.controller;
using System.Drawing;
using System.Linq;
using System.Text;
using AForge.Video.DirectShow;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace otomasyon
{
    public partial class meyveSebze : Form
    {
        int sayi1;
        int sayi2;
        int islem;
        int toplam = 0;
        
        public meyveSebze()
        {
            InitializeComponent();

        }
        
        private void bir_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = int.Parse(txt_sonuc.Text);
            txt_sonuc.Text = "0";
            
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_sonuc.Text == "0")
            {
                txt_sonuc.Text = "";

            }
            txt_sonuc.Text += ((Button)sender).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = int.Parse(txt_sonuc.Text);
            txt_sonuc.Text = "0";
            

        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = int.Parse(txt_sonuc.Text);
            txt_sonuc.Text = "0";
            

        }

        private void btn_böl_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = int.Parse(txt_sonuc.Text);
            txt_sonuc.Text = "0";

        }
        FilterInfoCollection fid;
        VideoCaptureDevice vid;
        private void meyveSebze_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            txt_sonuc.Text = toplam.ToString();
            fid = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo fi in fid)
            {
                cb_camera.Items.Add(fi.Name);
            }

        }


        private void btn_sonuc_Click(object sender, EventArgs e)
        {
            if (islem == 1)
            {
                sayi2 = int.Parse(txt_sonuc.Text);
                toplam = sayi1 + sayi2;
                txt_sonuc.Text = toplam.ToString();
            }
            else if (islem == 2)
            {
                sayi2 = int.Parse(txt_sonuc.Text);
                toplam = sayi1 - sayi2;
                txt_sonuc.Text = toplam.ToString();
            }
            else if (islem == 3)
            {
                sayi2 = int.Parse(txt_sonuc.Text);
                toplam = sayi1 * sayi2;
                txt_sonuc.Text = toplam.ToString();
            }
            else if (islem == 4)
            {
                sayi2 = int.Parse(txt_sonuc.Text);
                toplam = sayi1 / sayi2;
                txt_sonuc.Text = toplam.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_sonuc.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txt_sonuc.Text.Length != 0)
            {
                txt_sonuc.Text = txt_sonuc.Text.Substring(0, txt_sonuc.Text.Length - 1);
            }
            else
            {
                txt_sonuc.Text = "0";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString();
            dakika.Text = DateTime.Now.Minute.ToString();
            saniye.Text = DateTime.Now.Second.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vid = new VideoCaptureDevice(fid[cb_camera.SelectedIndex].MonikerString);
            vid.NewFrame += Vid_NewFrame;
            vid.Start();
            timer2.Start();
        }

        private void Vid_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox5.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vid.Stop();
            pictureBox5.Image = Image.FromFile(@"C:\Users\Devran\Desktop\Kısayollar\png-transparent-espresso-coffee-industry-service-business-camera-lens-lens-company-camera-lens.png");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBox5.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    timer1.Stop();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            txt_sonuc.Text = controller.getUrun(textBox1.Text).urunFiyat.ToString();
            urunadi.Text = controller.getUrun(textBox1.Text).urunAdi.ToString();

        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kasiyer ks = new Kasiyer();
            ks.Show();
        }
    }
}
