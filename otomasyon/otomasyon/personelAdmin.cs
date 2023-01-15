using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using otomasyon.controller;
using System.Threading.Tasks;
using System.Windows.Forms;
using otomasyon.model;

namespace otomasyon
{
    public partial class personelAdmin : Form
    {
        public personelAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void degerekle()
        {
            bolge.Items.Add("Beyoglu");
            bolge.Items.Add("Adalar");
            bolge.Items.Add("Esenyurt");
            bolge.Items.Add("Kartal");
            ///////////////////////////
            yetki.Items.Add("admin");
            yetki.Items.Add("kasiyer");
            //////////////////////////
            soru.Items.Add("En sevdiğiniz şey");
            soru.Items.Add("En sevdiğiniz hayvan");
        }
        private void personelAdmin_Load(object sender, EventArgs e)
        {

            Controller controller = new Controller();
            dataGridView1.DataSource = controller.getLoginTable();
            degerekle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bolge.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            soru.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_cevap.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.kullaniciEkle(txt_ka.Text, txt_sifre.Text, yetki.SelectedItem.ToString(), bolge.SelectedItem.ToString(), txt_email.Text, soru.SelectedItem.ToString(), txt_cevap.Text);
            dataGridView1.DataSource = controller.getLoginTable();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.kullaniciSil(txt_ka.Text, txt_sifre.Text);
            dataGridView1.DataSource = controller.getLoginTable();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            controller.guncelle(txt_ka.Text, txt_sifre.Text, yetki.SelectedItem.ToString(), bolge.SelectedItem.ToString(), txt_email.Text, soru.SelectedItem.ToString(), txt_cevap.Text,int.Parse(txt_id.Text));
            dataGridView1.DataSource = controller.getLoginTable();

        }
    }
}
