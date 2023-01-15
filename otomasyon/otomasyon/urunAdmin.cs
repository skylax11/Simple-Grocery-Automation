using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using otomasyon.controller;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
{
    public partial class urunAdmin : Form
    {
        public urunAdmin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void urunAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet7.Urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter1.Fill(this.marketDataSet7.Urun);


            Controller controller = new Controller();
            data.DataSource = controller.geturun();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = data.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = data.CurrentRow.Cells[7].Value.ToString();
            txt_barkod.Text = data.CurrentRow.Cells[6].Value.ToString();
            olusmatarih.Text = data.CurrentRow.Cells[2].Value.ToString();
            guncellenmetarih.Text = data.CurrentRow.Cells[3].Value.ToString();
            txt_kg.Text = data.CurrentRow.Cells[1].Value.ToString();
            txt_fiyat.Text = data.CurrentRow.Cells[5].Value.ToString();
            txt_ciro.Text = data.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.urunekle(int.Parse(txt_id.Text), txt_ad.Text, txt_barkod.Text, Convert.ToDateTime(olusmatarih.Text), Convert.ToDateTime(guncellenmetarih.Text), int.Parse(txt_kg.Text), int.Parse(txt_fiyat.Text), int.Parse(txt_ciro.Text));
            data.DataSource = controller.geturun();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_barkod_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_kg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_fiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_ciro_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void olusmatarih_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void guncellenmetarih_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void guncellenmetarih_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void olusmatarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.urunGuncelle(int.Parse(txt_id.Text),txt_ad.Text,txt_barkod.Text,Convert.ToDateTime(olusmatarih.Text),Convert.ToDateTime(guncellenmetarih.Text),double.Parse(txt_kg.Text),int.Parse(txt_fiyat.Text),int.Parse(txt_ciro.Text));
            controller.guncel(int.Parse(txt_id.Text));
            data.DataSource = controller.geturun();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.urunSil(txt_ad.Text);
            data.DataSource = controller.geturun();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.urunekle(int.Parse(txt_id.Text), txt_ad.Text, txt_barkod.Text, Convert.ToDateTime(olusmatarih.Text), Convert.ToDateTime(guncellenmetarih.Text), int.Parse(txt_kg.Text), int.Parse(txt_fiyat.Text), int.Parse(txt_ciro.Text));
            data.DataSource = controller.geturun();
        }
    }
}
