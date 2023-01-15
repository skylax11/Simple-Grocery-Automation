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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void dön(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void urunmenu(object sender, EventArgs e)
        {
            this.Hide();
            urunAdmin admin = new urunAdmin();
            admin.Show();
        }

        private void personelMenu(object sender, EventArgs e)
        {
            this.Hide();
            personelAdmin admin = new personelAdmin();
            admin.Show();
        }
    }
}
