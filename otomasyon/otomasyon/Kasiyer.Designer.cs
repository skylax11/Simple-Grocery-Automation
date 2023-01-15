namespace otomasyon
{
    partial class Kasiyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasiyer));
            this.btn_geridon = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.baklagiller = new System.Windows.Forms.PictureBox();
            this.eturunleri = new System.Windows.Forms.PictureBox();
            this.suturunleri = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.baklagiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eturunleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suturunleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geridon
            // 
            this.btn_geridon.Location = new System.Drawing.Point(47, 386);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(99, 33);
            this.btn_geridon.TabIndex = 4;
            this.btn_geridon.Text = "Geri Dön";
            this.btn_geridon.UseVisualStyleBackColor = true;
            this.btn_geridon.Click += new System.EventHandler(this.btn_geridon_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "meat-outline-filled.png");
            this.ımageList1.Images.SetKeyName(1, "images.png");
            this.ımageList1.Images.SetKeyName(2, "3362707.png");
            this.ımageList1.Images.SetKeyName(3, "adana-toptan-bakliyat-1.jpg");
            // 
            // baklagiller
            // 
            this.baklagiller.Image = ((System.Drawing.Image)(resources.GetObject("baklagiller.Image")));
            this.baklagiller.Location = new System.Drawing.Point(47, 222);
            this.baklagiller.Name = "baklagiller";
            this.baklagiller.Size = new System.Drawing.Size(143, 119);
            this.baklagiller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baklagiller.TabIndex = 2;
            this.baklagiller.TabStop = false;
            this.baklagiller.Click += new System.EventHandler(this.baklagiller_Click);
            // 
            // eturunleri
            // 
            this.eturunleri.Image = ((System.Drawing.Image)(resources.GetObject("eturunleri.Image")));
            this.eturunleri.Location = new System.Drawing.Point(47, 34);
            this.eturunleri.Name = "eturunleri";
            this.eturunleri.Size = new System.Drawing.Size(143, 119);
            this.eturunleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eturunleri.TabIndex = 0;
            this.eturunleri.TabStop = false;
            this.eturunleri.Click += new System.EventHandler(this.eturunleri_Click);
            // 
            // suturunleri
            // 
            this.suturunleri.Image = ((System.Drawing.Image)(resources.GetObject("suturunleri.Image")));
            this.suturunleri.Location = new System.Drawing.Point(284, 34);
            this.suturunleri.Name = "suturunleri";
            this.suturunleri.Size = new System.Drawing.Size(143, 119);
            this.suturunleri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.suturunleri.TabIndex = 3;
            this.suturunleri.TabStop = false;
            this.suturunleri.Click += new System.EventHandler(this.suturunleri_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::otomasyon.Properties.Resources._3362707;
            this.pictureBox1.Location = new System.Drawing.Point(284, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(465, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.suturunleri);
            this.Controls.Add(this.baklagiller);
            this.Controls.Add(this.eturunleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kasiyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasiyer";
            this.Load += new System.EventHandler(this.Kasiyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baklagiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eturunleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suturunleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox baklagiller;
        private System.Windows.Forms.PictureBox eturunleri;
        private System.Windows.Forms.PictureBox suturunleri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}