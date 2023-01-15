using System;
using otomasyon.enumaration;
using otomasyon.model;
using otomasyon.controller;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace otomasyon
{
    public partial class sifreDegistir : Form
    {
        int code;
        public sifreDegistir()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sifreDegistir_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.getLoginTable();
            List<LoginTable> logintablelist = controller.getLoginTable();
            comboBox1.Items.Add("En sevdiğiniz şey");
            comboBox1.Items.Add("En sevdiğiniz hayvan");
            gb_sifredegistir.Enabled = false;
            gb_kodsorgu.Enabled = false;
        }

        private void btn_sorgu_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            loginStatus loginstatus = controller.doAuthentication(txt_ka2.Text, comboBox1.SelectedItem.ToString(), txt_cevap.Text);
            if (loginstatus == loginStatus.basarili)
            {
                gb_kodsorgu.Enabled = true;
            }
            else if (loginstatus == loginStatus.basarisiz)
            {
                MessageBox.Show("Başarısız Sorgulama.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eksik Parametre Girdiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gb_guvenliksoru_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kodgonder_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            loginStatus gelendeger = controller.checkEmailAddress(txt_email.Text);

            if (gelendeger == loginStatus.basarili)
            {
                Random rnd = new Random();
                code = rnd.Next(6666, 9999);
                MailAddress mailAlan = new MailAddress(txt_email.Text, "Ahmet Kıran");
                MailAddress mailGonderen = new MailAddress("devranpvp@hotmail.com", "Devran Yılmaz");
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz:" + code;
                try
                {
                    SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
                    smtp.Credentials = new System.Net.NetworkCredential("devranpvp@hotmail.com", "Pvp12345.1wa1wa24");
                    smtp.EnableSsl = true;
                    smtp.Send(mesaj);
                    MessageBox.Show("Kod gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bir hata oluştu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kayıtlı olduğunuz email ile girdiğiniz email uyuşmamakta.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btn_kodsorgula_Click(object sender, EventArgs e)
        {
            if (code == int.Parse((txt_kod.Text)))
            {
                gb_sifredegistir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Yanlış kod girdiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            loginStatus gelendeger = controller.sifreDegistir(txt_ka2.Text, txt_yenisifre.Text);
            if (gelendeger == loginStatus.basarili && txt_yenisifre.Text == txt_yenisifretekrar.Text)
            {

                MessageBox.Show("Şifreniz başarılı bir şekilde değiştirildi. Lütfen tekrar giriş yapınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
                MailAddress mailAlan = new MailAddress(txt_email.Text, "Ahmet Kıran");
                MailAddress mailGonderen = new MailAddress("devranpvp@hotmail.com", "Devran Yılmaz");
                MailMessage mesaj = new MailMessage();
                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme Başarılı";
                mesaj.Body = "Şifreniz başarılı bir şekilde değiştirildi. Yeni şifreniz:" + " " + txt_yenisifre.Text;
                try
                {
                    SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
                    smtp.Credentials = new System.Net.NetworkCredential("devranpvp@hotmail.com", "Pvp12345.1wa1wa24");
                    smtp.EnableSsl = true;
                    smtp.Send(mesaj);

                }
                catch (Exception hata)
                {
                }

            }
            else if (string.IsNullOrEmpty(txt_yenisifretekrar.Text) || string.IsNullOrEmpty(txt_yenisifre.Text))
            {
                MessageBox.Show("Lütfen boş yer bırakmayınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gb_kodsorgu.Enabled = false;
                gb_sifredegistir.Enabled = false;
                txt_email.Text = null;
                txt_yenisifre.Text = null;
                txt_yenisifretekrar.Text = null;
                txt_kod.Text = null;

            }
            else if (txt_yenisifre.Text != txt_yenisifretekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Hatalı deneme. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
